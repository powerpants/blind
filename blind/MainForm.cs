using blind;
using devDept.Controls.WinForms;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using devDept.Graphics;
using devDept.Serialization;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blind
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            model.SelectionChanged += modelSelectionChanged;

            model.WorkCompleted += modelWorkCompleted;
            model.WorkCancelled += modelWorkCanceled;
            model.WorkFailed += modelWorkFailed;
            
            init();

            base.OnLoad(e);
        }

        //初始化
        private void init()
        {
            model.Camera.ProjectionMode = projectionType.Perspective;
            model.DisplayMode = displayType.Rendered;

            model.Turbo.MaxComplexity = 3000;

        }

        //加载窗口
        private void MainForm_Load(object sender, EventArgs e)
        {
            areaTextBox.Text = " " + string.Format("{0:F3}", 0) + " spuare " + model.Units.ToString().ToLower();
            volumnTextBox.Text = " " + string.Format("{0:F3}", 0) + " cubic " + model.Units.ToString().ToLower();
            splitContainer.FixedPanel = FixedPanel.Panel2;
            splitContainer.IsSplitterFixed = true;
            loadModel();
        }


        private void loadModel()
        {
            ReadOBJ rf = new ReadOBJ("../../fan.obj");

            rf.DoWork();

            Entity[] entities = rf.Entities;
            model.Materials = rf.Materials;
            model.Entities.Add(entities[0]);
            model.Entities.Add(entities[1]);
            for (int i = 2; i < 5; i++)
            {
                Block b = new Block(i.ToString());
                b.Entities.Add(entities[i]);
                model.Blocks.Add(b);
                model.Entities.Add(new Rotating(i.ToString()));
            }

            changeView(viewType.Isometric);
        }


        /*
         * View Pannel - 视图功能模块
         */

        //改变视图
        private void changeView(viewType type)
        {
            model.SetView(type, false, model.AnimateCamera);
            model.Invalidate();
        }

        private void frontViewButton_Click(object sender, EventArgs e)
        {
            changeView(viewType.Front);
        }

        private void topViewButton_Click(object sender, EventArgs e)
        {
            changeView(viewType.Top);
        }

        private void leftViewButton_Click(object sender, EventArgs e)
        {
            changeView(viewType.Left);
        }

        private void rightViewButton_Click(object sender, EventArgs e)
        {
            changeView(viewType.Right);
        }


        //切换视角
        private void changeProjectionType(projectionType type)
        {
            model.Camera.ProjectionMode = type;
            model.AdjustNearAndFarPlanes();
            model.Invalidate();
        }

        private void projectionRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                switch (radio.Name)
                {
                    case "parallelRadio":
                        changeProjectionType(projectionType.Orthographic);
                        break;
                    case "perspectiveRadio":
                        changeProjectionType(projectionType.Perspective);
                        break;
                    default:
                        break;
                }
            }

        }


        //改变视图过渡动画
        private void changeViewAnimationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            model.AnimateCamera = changeViewAnimationCheckBox.Checked;
        }

        //上个视角
        private void previousViewButton_Click(object sender, EventArgs e)
        {
            model.PreviousView();
            model.Invalidate();
        }

        //下个视角
        private void nextViewButton_Click(object sender, EventArgs e)
        {
            model.NextView();
            model.Invalidate();
        }



        /*
         * Shading pannel - 显示视图模块
         */

        //改变显示模式
        private void changeShadingType(displayType type)
        {
            model.DisplayMode = type;
            SetBackgroundStyleAndColor();
            model.Entities.UpdateBoundingBox(); // Updates simplified representation (when available)
            model.Invalidate();
        }

        //显示模式详细设置
        public void SetBackgroundStyleAndColor()
        {
            model.CoordinateSystemIcon.Lighting = false;
            model.ViewCubeIcon.Lighting = false;

            switch (model.DisplayMode)
            {
                case displayType.HiddenLines:
                    model.Background.TopColor = Color.FromArgb(0xD2, 0xD0, 0xB9);
                    model.CoordinateSystemIcon.Lighting = true;
                    model.ViewCubeIcon.Lighting = true;
                    break;
                default:
                    model.Background.TopColor = Color.Snow;
                    break;
            }

            model.CompileUserInterfaceElements();
        }

        private void shadingRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                switch (radio.Name)
                {
                    case "wireframeShadingRadio":
                        changeShadingType(displayType.Wireframe);
                        break;
                    case "shadedShadingRadio":
                        changeShadingType(displayType.Shaded);
                        break;
                    case "renderedShadingRadio":
                        changeShadingType(displayType.Rendered);
                        break;
                    case "flatShadingRadio":
                        changeShadingType(displayType.Flat);
                        break;
                    case "hiddenLinesShadingRadio":
                        changeShadingType(displayType.HiddenLines);
                        break;
                    default:
                        break;
                }
            }
        }

        /*
         * Scene Panel - 场景模块
         */

        //startwork完成回调
        private void modelWorkCompleted(object sender, WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFileAsync)
            {
                ReadFileAsync rfa = (ReadFileAsync)e.WorkUnit;
                rfa.AddToScene(model);

                model.SetView(viewType.Trimetric, true, model.AnimateCamera);
            }
            setFileButtonEnabled(true);
        }

        //取消回调
        private void modelWorkCanceled(object sender, EventArgs e)
        {
            MessageBox.Show("Operation Canceled.");
            setFileButtonEnabled(true);
        }

        //失败回调
        private void modelWorkFailed(object sender, WorkFailedEventArgs e)
        {
            MessageBox.Show("Operation Failed.");
            setFileButtonEnabled(true);
        }


        private OpenFileAddOn _openFileAddOn;
        private void openButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Eyeshot (*.eye)|*.eye";
                openFileDialog1.Multiselect = false;
                openFileDialog1.AddExtension = true;
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.DereferenceLinks = true;

                _openFileAddOn = new OpenFileAddOn();
                _openFileAddOn.EventFileNameChanged += OpenFileAddOn_EventFileNameChanged;

                if (openFileDialog1.ShowDialog(_openFileAddOn, this) == DialogResult.OK)
                {
                    model.Clear();
                    ReadFile readFile = new ReadFile(openFileDialog1.FileName, (contentType)_openFileAddOn.ContentOption);
                    model.StartWork(readFile);
                    model.SetView(viewType.Trimetric, true, model.AnimateCamera);
                    setFileButtonEnabled(false);
                }

                _openFileAddOn.EventFileNameChanged -= OpenFileAddOn_EventFileNameChanged;
                _openFileAddOn.Dispose();
                _openFileAddOn = null;
            }
        }

        private void OpenFileAddOn_EventFileNameChanged(IWin32Window sender, string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                ReadFile rf = new ReadFile(filePath, true);
                _openFileAddOn.SetFileInfo(rf.GetThumbnail(), rf.GetFileInfo());
            }
            else
            {
                _openFileAddOn.ResetFileInfo();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            using (var saveFileAddOn = new SaveFileAddOn())
            {
                saveFileDialog.Filter = "Eyeshot (*.eye)|*.eye";
                saveFileDialog.AddExtension = true;
                saveFileDialog.CheckPathExists = true;

                if (saveFileDialog.ShowDialog(saveFileAddOn, this) == DialogResult.OK)
                {
                    WriteFile writeFile = new WriteFile(new WriteFileParams(model) { Content = (contentType)saveFileAddOn.ContentOption, SerializationMode = (serializationType)saveFileAddOn.SerialOption, SelectedOnly = saveFileAddOn.SelectedOnly, Purge = saveFileAddOn.Purge }, saveFileDialog.FileName);
                    model.StartWork(writeFile);
                    setFileButtonEnabled(false);
                }
            }
        }


        //导入
        private void importButton_Click(object sender, EventArgs e)
        {
            using (var importFileDialog1 = new OpenFileDialog())
            using (var importFileAddOn = new ImportFileAddOn())
            {
                string theFilter = "All compatible file types (*.*)|*.asc;*.stl;*.obj;*.las;*.3ds";
                theFilter += ";*.igs;*.iges;*.stp;*.step";
                theFilter += "|Points (*.asc)|*.asc|" + "WaveFront OBJ (*.obj)|*.obj|" + "Stereolithography (*.stl)|*.stl|" + "Laser LAS (*.las)|*.las|" + "3D Studio Max (*.3ds)|*.3ds";
                theFilter += "|IGES (*.igs; *.iges)|*.igs; *.iges|" + "STEP (*.stp; *.step)|*.stp; *.step";

                importFileDialog1.Filter = theFilter;

                importFileDialog1.Multiselect = false;
                importFileDialog1.AddExtension = true;
                importFileDialog1.CheckFileExists = true;
                importFileDialog1.CheckPathExists = true;

                if (importFileDialog1.ShowDialog(importFileAddOn, this) == DialogResult.OK)
                {
                    model.Clear();
                    ReadFileAsync rfa = getReader(importFileDialog1.FileName);

                    if (rfa != null)
                    {
                        model.StartWork(rfa);
                        setFileButtonEnabled(false);
                    }
                }
            }
        }

        private void setFileButtonEnabled(bool status)
        {
            openButton.Enabled = status;
            saveButton.Enabled = status;
            importButton.Enabled = status;
            exportButton.Enabled = status;
        }

        private ReadFileAsync getReader(string fileName)
        {
            string ext = System.IO.Path.GetExtension(fileName);

            if (ext != null)
            {
                ext = ext.TrimStart('.').ToLower();

                switch (ext)
                {
                    case "asc":
                        return new ReadASC(fileName);
                    case "stl":
                        return new ReadSTL(fileName);
                    case "obj":
                        return new ReadOBJ(fileName);
                    case "las":
                        return new ReadLAS(fileName);
                    case "3ds":
                        return new Read3DS(fileName);

                    case "igs":
                    case "iges":
                        return new ReadIGES(fileName);

                    case "stp":
                    case "step":
                        return new ReadSTEP(fileName);
                }
            }
            return null;
        }


        //导出
        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string theFilter = "WaveFront OBJ (*.obj)|*.obj|" + "Stereolithography (*.stl)|*.stl|" + "Laser LAS (*.las)|*.las|" + "WebGL (*.html)|*.html";
            theFilter += "|STandard for the Exchange of Product (*.step)|*.step|" + "Initial Graphics Exchange Specification (*.iges)|*.iges";

            saveFileDialog1.Filter = theFilter;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteFileAsync wfa = null;
                WriteParams dataParams;

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        dataParams = new WriteParamsWithMaterials(model);
                        wfa = new WriteOBJ((WriteParamsWithMaterials)dataParams, saveFileDialog1.FileName);
                        break;

                    case 2:
                        dataParams = new WriteParams(model);
                        wfa = new WriteSTL(dataParams, saveFileDialog1.FileName);
                        break;
                    case 3:
                        dataParams = null;
                        wfa = new WriteLAS(model.Entities.Where(x => x is FastPointCloud).FirstOrDefault() as FastPointCloud, saveFileDialog1.FileName);
                        break;
                    case 4:
                        dataParams = new WriteParamsWithMaterials(model);
                        wfa = new WriteWebGL((WriteParamsWithMaterials)dataParams, model.DefaultMaterial, saveFileDialog1.FileName);
                        break;
                    case 5:
                        dataParams = new WriteParamsWithUnits(model);
                        wfa = new WriteSTEP((WriteParamsWithUnits)dataParams, saveFileDialog1.FileName);
                        break;

                    case 6:
                        dataParams = new WriteParamsWithUnits(model);
                        wfa = new WriteIGES((WriteParamsWithUnits)dataParams, saveFileDialog1.FileName);
                        break;
                }

                model.StartWork(wfa);
            }
        }


        /*
         * Selection Panel - 选择模块
         */

        private void selectionRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                changeSelectionStatus(radio.Name);
            }
        }

        private void changeSelectionStatus(String radioName)
        {
            switch (radioName)
            {
                case "noneSelectionRadio":
                    transform = false;
                    transforming = false;

                    model.ObjectManipulator.Cancel();

                    model.ActionMode = actionType.None;
                    model.Entities.ClearSelection();
                    model.Invalidate();

                    setSelectionRadioEnabled(true);
                    break;
                case "pickSelectionRadio":
                    if (transforming) break;
                    model.ActionMode = actionType.SelectVisibleByPick;
                    transform = true;
                    break;
                case "boxSelectionRadio":
                    if (transforming) break;
                    model.ActionMode = actionType.SelectByBox;
                    transform = true;
                    break;
                case "encloseSelectionRadio":
                    if (transforming) break;
                    model.ActionMode = actionType.SelectByBoxEnclosed;
                    transform = true;
                    break;
                default:
                    break;
            }
        }

        // transform
        private bool transform = false; //开启变换
        private bool transforming = false; //正在进行变换

        private void model_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            if (m.Button == MouseButtons.Right)
            {
                if (transform)
                {
                    if (transforming)
                    {
                        model.ObjectManipulator.Apply();
                        model.ObjectManipulator.Cancel();
                        model.Entities.Regen();
                        transforming = false;
                        setSelectionRadioEnabled(true);
                    }
                    else
                        modelTransform();

                }
            }
        }

        private void setSelectionRadioEnabled(bool status)
        {
            boxSelectionRadio.Enabled = status;
            pickSelectionRadio.Enabled = status;
            encloseSelectionRadio.Enabled = status;
        }

        private void modelTransform()
        { 
            Entity temp = null;
            foreach (Entity ent in model.Entities)
            {
                if (ent.Selected)
                {
                    temp = ent;
                    break;
                }
            }
            if (temp != null)
            {
                transforming = true;
                setSelectionRadioEnabled(false);
                Transformation center = new Translation(temp.BoxMin.X, temp.BoxMin.Y, temp.BoxMin.Z);
                model.ObjectManipulator.Enable(center, false);
                model.ObjectManipulator.ScaleX.Visible = true;
                model.ObjectManipulator.ScaleY.Visible = true;
                model.ObjectManipulator.ScaleZ.Visible = true;
                model.ObjectManipulator.ShowOriginalWhileEditing = false;
                model.CompileUserInterfaceElements();

                model.Invalidate();
            }
            else
                return;
        }

        // ESE取消本次移动
        private void model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (transforming)
                {
                    transforming = false;
                    model.ObjectManipulator.Cancel();
                    model.Entities.Regen();
                    setSelectionRadioEnabled(true);
                }
            }

            if (e.KeyCode == Keys.R)
            {
                MessageBox.Show("run!!!!");
                model.StartAnimation(1);
                model.Invalidate();
            }

            if (e.KeyCode == Keys.S)
            {
                MessageBox.Show("stop!!!!");
                if (model.IsAnimationRunning)
                {
                    model.StopAnimation();
                    model.Invalidate();
                }
            }
        }



        /*
         * Video Panel - 录制模块
         */
        private ScreenRecorder recorder = null;

        private ScreenRecorder GetRecorder()
        {
            if (recorder == null)
                recorder = new ScreenRecorder();
            return recorder;
        }

        private void videoStartButton_Click(object sender, EventArgs e)
        {
            videoStartButton.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            System.Drawing.Point screenPoint = model.PointToScreen(new System.Drawing.Point());
            screenPoint.X = (int)(screenPoint.X * ScreenProp.ScaleX);
            screenPoint.Y = (int)(screenPoint.Y * ScreenProp.ScaleY);
            GetRecorder().Start(new Rectangle(screenPoint, new Size() {
                Width = even((int)(model.Size.Width * ScreenProp.ScaleX)),
                Height = even((int)(model.Size.Height * ScreenProp.ScaleY))
            }));
            videoStopButton.Enabled = true;
        }


        private int even(int x)
        {
            return x % 2 == 0 ? x : x - 1;
        }


        private void videoStopButton_Click(object sender, EventArgs e)
        {
            GetRecorder().Stop();
            videoStartButton.Enabled = true;
            videoStopButton.Enabled = false;
            this.MaximizeBox = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }



        /*
         * Detail Panel - 详情模块
         */

        private void boundingBoxButton_CheckedChanged(object sender, EventArgs e)
        {
            model.BoundingBox.Visible = boundingBoxButton.Checked;
            model.Invalidate();
        }

        //模型选择change事件
        private void modelSelectionChanged(object sender, Model.SelectionChangedEventArgs e)
        {
            if (noneSelectionRadio.Checked)
            {
                areaTextBox.Text = " " + string.Format("{0:F3}", 0) + " spuare " + model.Units.ToString().ToLower();
                volumnTextBox.Text = " " + string.Format("{0:F3}", 0) + " cubic " + model.Units.ToString().ToLower();
            }
            else
            {
                //计算面积和体积
                computeAreaAndVolume(false);
            }
        }

        //异步计算并更新界面
        private async void computeAreaAndVolume(bool all = false)
        {
            await Task.Run(() =>
            {
                int count = 0;
                AreaProperties ap = computeArea(out count, all);
                VolumeProperties vp = computeVolume(out count, all);
                areaTextBox.Text = " " + string.Format("{0:F3}", ap.Area) + " spuare " + model.Units.ToString().ToLower();
                volumnTextBox.Text = " " + string.Format("{0:F3}", vp.Volume) + " cubic " + model.Units.ToString().ToLower();
            });
        }

        //计算选中模型面积
        private AreaProperties computeArea(out int count, bool all = false)
        {
            AreaProperties ap = new AreaProperties();
            count = 0;
            var blockReferenceNotScaled = true;
            for (int i = 0; i < model.Entities.Count && blockReferenceNotScaled; i++)
            {

                Entity ent = model.Entities[i];

                count += AddAreaProperty(ap, ent, out blockReferenceNotScaled, all);
            }
            return ap;
        }

        //累加模型面积
        private int AddAreaProperty(AreaProperties ap, Entity ent, out bool blockReferenceNotScaled, bool isParentSelected = false, bool all = false)
        {
            int count = 0;
            blockReferenceNotScaled = true;

            if (all || ent.Selected || isParentSelected)
            {
                if (ent is IFace)
                {
                    IFace itfFace = (IFace)ent;

                    Mesh[] meshes = itfFace.GetPolygonMeshes();

                    foreach (Mesh mesh in meshes)
                    {
                        ap.Add(mesh.Vertices, mesh.Triangles);
                    }
                    count++;
                }
                else if (ent is BlockReference)
                {
                    var br = (BlockReference)ent;

                    if (br.GetScaleFactorX() != 1 &&
                         br.GetScaleFactorY() != 1 &&
                         br.GetScaleFactorZ() != 1)
                    {
                        blockReferenceNotScaled = false;
                        return count;
                    }

                    foreach (var e in br.GetEntities(model.Blocks))
                    {
                        count += AddAreaProperty(ap, e, out blockReferenceNotScaled, true);

                        if (!blockReferenceNotScaled) return count;
                    }
                }
                else
                {
                    ICurve itfCurve = (ICurve)ent;

                    if (itfCurve.IsClosed)
                        ap.Add(ent.Vertices);

                    count++;
                }

            }
            else if (ent is Brep)
            {
                Brep brep = (Brep)ent;

                for (int j = 0; j < brep.Faces.Length; j++)
                {
                    Brep.Face sf = brep.Faces[j];
                    Mesh[] faceTessellation = sf.Tessellation;

                    if (brep.GetFaceSelection(j))
                    {
                        foreach (Mesh m in faceTessellation)
                            ap.Add(m.Vertices, m.Triangles);

                        count++;
                    }
                }
            }
            return count;
        }

        //计算选中模型体积
        private VolumeProperties computeVolume(out int count, bool all = false)
        {
            VolumeProperties vp = new VolumeProperties();

            count = 0;
            var blockReferenceNotScaled = true;

            for (int i = 0; i < model.Entities.Count && blockReferenceNotScaled; i++)
            {
                Entity ent = model.Entities[i];

                count += AddVolumeProperty(vp, ent, out blockReferenceNotScaled,all);
            }

            return vp;
        }

        //累加模型体积
        private int AddVolumeProperty(VolumeProperties vp, Entity ent, out bool blockReferenceNotScaled, bool all = false, bool isParentSelected = false)
        {
            int count = 0;
            blockReferenceNotScaled = true;

            if (all || ent.Selected || isParentSelected)
            {
                if (ent is IFace)
                {
                    IFace itfFace = (IFace)ent;

                    Mesh[] meshes = itfFace.GetPolygonMeshes();

                    foreach (Mesh mesh in meshes)
                    {
                        vp.Add(mesh.Vertices, mesh.Triangles);
                    }
                    count++;
                }
                else if (ent is BlockReference)
                {
                    var br = (BlockReference)ent;

                    if (br.GetScaleFactorX() != 1 &&
                         br.GetScaleFactorY() != 1 &&
                         br.GetScaleFactorZ() != 1)
                    {
                        blockReferenceNotScaled = false;
                        return count;
                    }

                    foreach (var e in br.GetEntities(model.Blocks))
                    {
                        count += AddVolumeProperty(vp, e, out blockReferenceNotScaled, true);

                        if (!blockReferenceNotScaled) return count;
                    }
                }

            }

            return count;
        }



        private Bitmap printScreen()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            System.Drawing.Point sceenPoint = model.PointToScreen(new System.Drawing.Point());
            sceenPoint.X = (int)(sceenPoint.X * ScreenProp.ScaleX);
            sceenPoint.Y = (int)(sceenPoint.Y * ScreenProp.ScaleY);
            Rectangle rect = new Rectangle(sceenPoint, new Size() {
                Width = (int)(model.Size.Width * ScreenProp.ScaleX),
                Height = (int)(model.Size.Height * ScreenProp.ScaleY)
            });
            
            Bitmap img = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(img);
            graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            return img;
        }


        //导出
        private void exportDetailButton_Click(object sender, EventArgs e)
        {
            if (transform)
            {
                transform = false;
                if (transforming)
                {
                    transforming = false;

                    model.ObjectManipulator.Cancel();
                    model.Invalidate();
                }
                openButton.Enabled = false;
                importButton.Enabled = false;
                exportDetailButton.Enabled = false;
            }

            //exportDetail();
            //var x = model.Viewports[model.Viewports.Count - 1];
            int entities, vertices, triangles, count;
            model.Entities.GetStats(model.Blocks, out entities, out vertices, out triangles);
            AreaProperties ap = computeArea(out count, true);
            VolumeProperties vp = computeVolume(out count, true);

            HtmlGenerator generator = new HtmlGenerator();
            generator.Units = model.Units.ToString().ToLower();
            generator.SetTable(entities, vertices, triangles,ap.Area,vp.Volume);

            Bitmap bitmap;
            bitmap = printScreen();

            generator.SetImage(bitmap);
            generator.Generate();
        }


        //异步
        private async void exportDetail()
        {
            await Task.Run(() =>
            {
                int count;
                AreaProperties area = computeArea(out count, true);
                VolumeProperties volume = computeVolume(out count, true);

                //导出操作

                //调用selection功能更新界面操作状态
                for (int i = 0; i < selectionGroup.Controls.Count; i++)
                {
                    if (selectionGroup.Controls[i] is RadioButton)
                    {
                        RadioButton radio = (RadioButton)selectionGroup.Controls[i];
                        changeSelectionStatus(radio.Name);
                    }
                }
            });
        }


        private void modelWorkCompleted2(object sender, WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFileAsync)
            {
                ReadFileAsync rfa = (ReadFileAsync)e.WorkUnit;
                rfa.AddToScene(model);

                model.SetView(viewType.Trimetric, true, model.AnimateCamera);
            }
            setFileButtonEnabled(true);
        }



        /*
         * Animation Panel - 动画
         */
        private void animationStartButton_Click(object sender, EventArgs e)
        {
            if (!model.IsAnimationRunning)
            {
                animationStartButton.Enabled = false;
                model.StartAnimation(1);
                model.Invalidate();
                animationStopButton.Enabled = true;
            }
        }

        private void animationStopButton_Click(object sender, EventArgs e)
        {
            if (model.IsAnimationRunning)
            {
                animationStartButton.Enabled = true;
                model.StopAnimation();
                model.Invalidate();
                animationStopButton.Enabled = false;
            }
        }
    }
}
