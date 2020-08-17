namespace Blind
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 5.0900007813803123D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(636, 509), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.model = new devDept.Eyeshot.Model();
            this.panel1 = new System.Windows.Forms.Panel();
            this.animationStartButton = new System.Windows.Forms.Button();
            this.animationStopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shadingGroup = new System.Windows.Forms.GroupBox();
            this.shadedShadingRadio = new System.Windows.Forms.RadioButton();
            this.renderedShadingRadio = new System.Windows.Forms.RadioButton();
            this.hiddenLinesShadingRadio = new System.Windows.Forms.RadioButton();
            this.wireframeShadingRadio = new System.Windows.Forms.RadioButton();
            this.flatShadingRadio = new System.Windows.Forms.RadioButton();
            this.selectionGroup = new System.Windows.Forms.GroupBox();
            this.pickSelectionRadio = new System.Windows.Forms.RadioButton();
            this.boxSelectionRadio = new System.Windows.Forms.RadioButton();
            this.encloseSelectionRadio = new System.Windows.Forms.RadioButton();
            this.noneSelectionRadio = new System.Windows.Forms.RadioButton();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.volumnTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.boundingBoxButton = new System.Windows.Forms.CheckBox();
            this.exportDetailButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.videoStartButton = new System.Windows.Forms.Button();
            this.videoStopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filePanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.sceneLabel = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.changeViewAnimationCheckBox = new System.Windows.Forms.CheckBox();
            this.nextViewButton = new System.Windows.Forms.Button();
            this.previousViewButton = new System.Windows.Forms.Button();
            this.parallelRadio = new System.Windows.Forms.RadioButton();
            this.perspectiveRadio = new System.Windows.Forms.RadioButton();
            this.rightViewButton = new System.Windows.Forms.Button();
            this.leftViewButton = new System.Windows.Forms.Button();
            this.topViewButton = new System.Windows.Forms.Button();
            this.frontViewButton = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            this.panel1.SuspendLayout();
            this.shadingGroup.SuspendLayout();
            this.selectionGroup.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.videoPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.Cursor = System.Windows.Forms.Cursors.Default;
            this.model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model.Location = new System.Drawing.Point(0, 0);
            this.model.Name = "model";
            this.model.ProgressBar = progressBar1;
            this.model.Size = new System.Drawing.Size(636, 509);
            this.model.TabIndex = 0;
            this.model.Text = "model";
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            viewport1.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.model.Viewports.Add(viewport1);
            this.model.Click += new System.EventHandler(this.model_Click);
            this.model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.model_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.animationStartButton);
            this.panel1.Controls.Add(this.animationStopButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 47);
            this.panel1.TabIndex = 8;
            // 
            // animationStartButton
            // 
            this.animationStartButton.Location = new System.Drawing.Point(23, 17);
            this.animationStartButton.Name = "animationStartButton";
            this.animationStartButton.Size = new System.Drawing.Size(80, 23);
            this.animationStartButton.TabIndex = 3;
            this.animationStartButton.Text = "Start";
            this.animationStartButton.UseVisualStyleBackColor = true;
            this.animationStartButton.Click += new System.EventHandler(this.animationStartButton_Click);
            // 
            // animationStopButton
            // 
            this.animationStopButton.Enabled = false;
            this.animationStopButton.Location = new System.Drawing.Point(118, 17);
            this.animationStopButton.Name = "animationStopButton";
            this.animationStopButton.Size = new System.Drawing.Size(80, 23);
            this.animationStopButton.TabIndex = 1;
            this.animationStopButton.Text = "Stop";
            this.animationStopButton.UseVisualStyleBackColor = true;
            this.animationStopButton.Click += new System.EventHandler(this.animationStopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Animation";
            // 
            // shadingGroup
            // 
            this.shadingGroup.Controls.Add(this.shadedShadingRadio);
            this.shadingGroup.Controls.Add(this.renderedShadingRadio);
            this.shadingGroup.Controls.Add(this.hiddenLinesShadingRadio);
            this.shadingGroup.Controls.Add(this.wireframeShadingRadio);
            this.shadingGroup.Controls.Add(this.flatShadingRadio);
            this.shadingGroup.Location = new System.Drawing.Point(2, 123);
            this.shadingGroup.Name = "shadingGroup";
            this.shadingGroup.Size = new System.Drawing.Size(200, 83);
            this.shadingGroup.TabIndex = 7;
            this.shadingGroup.TabStop = false;
            this.shadingGroup.Text = "Shading";
            // 
            // shadedShadingRadio
            // 
            this.shadedShadingRadio.AutoSize = true;
            this.shadedShadingRadio.Location = new System.Drawing.Point(105, 20);
            this.shadedShadingRadio.Name = "shadedShadingRadio";
            this.shadedShadingRadio.Size = new System.Drawing.Size(59, 16);
            this.shadedShadingRadio.TabIndex = 2;
            this.shadedShadingRadio.Text = "Shaded";
            this.shadedShadingRadio.UseVisualStyleBackColor = true;
            this.shadedShadingRadio.CheckedChanged += new System.EventHandler(this.shadingRadio_CheckedChanged);
            // 
            // renderedShadingRadio
            // 
            this.renderedShadingRadio.AutoSize = true;
            this.renderedShadingRadio.Checked = true;
            this.renderedShadingRadio.Location = new System.Drawing.Point(105, 41);
            this.renderedShadingRadio.Name = "renderedShadingRadio";
            this.renderedShadingRadio.Size = new System.Drawing.Size(71, 16);
            this.renderedShadingRadio.TabIndex = 3;
            this.renderedShadingRadio.TabStop = true;
            this.renderedShadingRadio.Text = "Rendered";
            this.renderedShadingRadio.UseVisualStyleBackColor = true;
            this.renderedShadingRadio.CheckedChanged += new System.EventHandler(this.shadingRadio_CheckedChanged);
            // 
            // hiddenLinesShadingRadio
            // 
            this.hiddenLinesShadingRadio.AutoSize = true;
            this.hiddenLinesShadingRadio.Location = new System.Drawing.Point(8, 61);
            this.hiddenLinesShadingRadio.Name = "hiddenLinesShadingRadio";
            this.hiddenLinesShadingRadio.Size = new System.Drawing.Size(89, 16);
            this.hiddenLinesShadingRadio.TabIndex = 5;
            this.hiddenLinesShadingRadio.Text = "HiddenLines";
            this.hiddenLinesShadingRadio.UseVisualStyleBackColor = true;
            this.hiddenLinesShadingRadio.CheckedChanged += new System.EventHandler(this.shadingRadio_CheckedChanged);
            // 
            // wireframeShadingRadio
            // 
            this.wireframeShadingRadio.AutoSize = true;
            this.wireframeShadingRadio.Location = new System.Drawing.Point(8, 20);
            this.wireframeShadingRadio.Name = "wireframeShadingRadio";
            this.wireframeShadingRadio.Size = new System.Drawing.Size(77, 16);
            this.wireframeShadingRadio.TabIndex = 1;
            this.wireframeShadingRadio.Text = "Wireframe";
            this.wireframeShadingRadio.UseVisualStyleBackColor = true;
            this.wireframeShadingRadio.CheckedChanged += new System.EventHandler(this.shadingRadio_CheckedChanged);
            // 
            // flatShadingRadio
            // 
            this.flatShadingRadio.AutoSize = true;
            this.flatShadingRadio.Location = new System.Drawing.Point(8, 41);
            this.flatShadingRadio.Name = "flatShadingRadio";
            this.flatShadingRadio.Size = new System.Drawing.Size(47, 16);
            this.flatShadingRadio.TabIndex = 4;
            this.flatShadingRadio.Text = "Flat";
            this.flatShadingRadio.UseVisualStyleBackColor = true;
            this.flatShadingRadio.CheckedChanged += new System.EventHandler(this.shadingRadio_CheckedChanged);
            // 
            // selectionGroup
            // 
            this.selectionGroup.Controls.Add(this.pickSelectionRadio);
            this.selectionGroup.Controls.Add(this.boxSelectionRadio);
            this.selectionGroup.Controls.Add(this.encloseSelectionRadio);
            this.selectionGroup.Controls.Add(this.noneSelectionRadio);
            this.selectionGroup.Location = new System.Drawing.Point(2, 300);
            this.selectionGroup.Name = "selectionGroup";
            this.selectionGroup.Size = new System.Drawing.Size(225, 44);
            this.selectionGroup.TabIndex = 6;
            this.selectionGroup.TabStop = false;
            this.selectionGroup.Text = "Selection";
            // 
            // pickSelectionRadio
            // 
            this.pickSelectionRadio.AutoSize = true;
            this.pickSelectionRadio.Location = new System.Drawing.Point(6, 20);
            this.pickSelectionRadio.Name = "pickSelectionRadio";
            this.pickSelectionRadio.Size = new System.Drawing.Size(47, 16);
            this.pickSelectionRadio.TabIndex = 2;
            this.pickSelectionRadio.Text = "Pick";
            this.pickSelectionRadio.UseVisualStyleBackColor = true;
            this.pickSelectionRadio.CheckedChanged += new System.EventHandler(this.selectionRadio_CheckedChanged);
            // 
            // boxSelectionRadio
            // 
            this.boxSelectionRadio.AutoSize = true;
            this.boxSelectionRadio.Location = new System.Drawing.Point(59, 20);
            this.boxSelectionRadio.Name = "boxSelectionRadio";
            this.boxSelectionRadio.Size = new System.Drawing.Size(41, 16);
            this.boxSelectionRadio.TabIndex = 3;
            this.boxSelectionRadio.Text = "Box";
            this.boxSelectionRadio.UseVisualStyleBackColor = true;
            this.boxSelectionRadio.CheckedChanged += new System.EventHandler(this.selectionRadio_CheckedChanged);
            // 
            // encloseSelectionRadio
            // 
            this.encloseSelectionRadio.AutoSize = true;
            this.encloseSelectionRadio.Location = new System.Drawing.Point(102, 20);
            this.encloseSelectionRadio.Name = "encloseSelectionRadio";
            this.encloseSelectionRadio.Size = new System.Drawing.Size(65, 16);
            this.encloseSelectionRadio.TabIndex = 5;
            this.encloseSelectionRadio.Text = "Enclose";
            this.encloseSelectionRadio.UseVisualStyleBackColor = true;
            this.encloseSelectionRadio.CheckedChanged += new System.EventHandler(this.selectionRadio_CheckedChanged);
            // 
            // noneSelectionRadio
            // 
            this.noneSelectionRadio.AutoSize = true;
            this.noneSelectionRadio.Checked = true;
            this.noneSelectionRadio.Location = new System.Drawing.Point(172, 20);
            this.noneSelectionRadio.Name = "noneSelectionRadio";
            this.noneSelectionRadio.Size = new System.Drawing.Size(47, 16);
            this.noneSelectionRadio.TabIndex = 4;
            this.noneSelectionRadio.TabStop = true;
            this.noneSelectionRadio.Text = "None";
            this.noneSelectionRadio.UseVisualStyleBackColor = true;
            this.noneSelectionRadio.CheckedChanged += new System.EventHandler(this.selectionRadio_CheckedChanged);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.volumeLabel);
            this.detailPanel.Controls.Add(this.areaLabel);
            this.detailPanel.Controls.Add(this.volumnTextBox);
            this.detailPanel.Controls.Add(this.areaTextBox);
            this.detailPanel.Controls.Add(this.boundingBoxButton);
            this.detailPanel.Controls.Add(this.exportDetailButton);
            this.detailPanel.Controls.Add(this.label3);
            this.detailPanel.Location = new System.Drawing.Point(2, 350);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(225, 102);
            this.detailPanel.TabIndex = 5;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(9, 75);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(41, 12);
            this.volumeLabel.TabIndex = 8;
            this.volumeLabel.Text = "Volume";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(9, 51);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(29, 12);
            this.areaLabel.TabIndex = 7;
            this.areaLabel.Text = "Area";
            // 
            // volumnTextBox
            // 
            this.volumnTextBox.Location = new System.Drawing.Point(57, 72);
            this.volumnTextBox.Name = "volumnTextBox";
            this.volumnTextBox.ReadOnly = true;
            this.volumnTextBox.Size = new System.Drawing.Size(162, 21);
            this.volumnTextBox.TabIndex = 6;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(57, 47);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.ReadOnly = true;
            this.areaTextBox.Size = new System.Drawing.Size(162, 21);
            this.areaTextBox.TabIndex = 5;
            // 
            // boundingBoxButton
            // 
            this.boundingBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.boundingBoxButton.AutoSize = true;
            this.boundingBoxButton.Location = new System.Drawing.Point(5, 16);
            this.boundingBoxButton.Name = "boundingBoxButton";
            this.boundingBoxButton.Size = new System.Drawing.Size(87, 22);
            this.boundingBoxButton.TabIndex = 4;
            this.boundingBoxButton.Text = "Bounding Box";
            this.boundingBoxButton.UseVisualStyleBackColor = true;
            this.boundingBoxButton.CheckedChanged += new System.EventHandler(this.boundingBoxButton_CheckedChanged);
            // 
            // exportDetailButton
            // 
            this.exportDetailButton.Location = new System.Drawing.Point(97, 16);
            this.exportDetailButton.Name = "exportDetailButton";
            this.exportDetailButton.Size = new System.Drawing.Size(122, 23);
            this.exportDetailButton.TabIndex = 3;
            this.exportDetailButton.Text = "Export To Html";
            this.exportDetailButton.UseVisualStyleBackColor = true;
            this.exportDetailButton.Click += new System.EventHandler(this.exportDetailButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detail";
            // 
            // videoPanel
            // 
            this.videoPanel.Controls.Add(this.videoStartButton);
            this.videoPanel.Controls.Add(this.videoStopButton);
            this.videoPanel.Controls.Add(this.label1);
            this.videoPanel.Location = new System.Drawing.Point(2, 252);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(225, 47);
            this.videoPanel.TabIndex = 3;
            // 
            // videoStartButton
            // 
            this.videoStartButton.Location = new System.Drawing.Point(23, 17);
            this.videoStartButton.Name = "videoStartButton";
            this.videoStartButton.Size = new System.Drawing.Size(80, 23);
            this.videoStartButton.TabIndex = 3;
            this.videoStartButton.Text = "Start";
            this.videoStartButton.UseVisualStyleBackColor = true;
            this.videoStartButton.Click += new System.EventHandler(this.videoStartButton_Click);
            // 
            // videoStopButton
            // 
            this.videoStopButton.Enabled = false;
            this.videoStopButton.Location = new System.Drawing.Point(118, 17);
            this.videoStopButton.Name = "videoStopButton";
            this.videoStopButton.Size = new System.Drawing.Size(80, 23);
            this.videoStopButton.TabIndex = 1;
            this.videoStopButton.Text = "Stop";
            this.videoStopButton.UseVisualStyleBackColor = true;
            this.videoStopButton.Click += new System.EventHandler(this.videoStopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video";
            // 
            // filePanel
            // 
            this.filePanel.Controls.Add(this.saveButton);
            this.filePanel.Controls.Add(this.openButton);
            this.filePanel.Controls.Add(this.exportButton);
            this.filePanel.Controls.Add(this.importButton);
            this.filePanel.Controls.Add(this.sceneLabel);
            this.filePanel.Location = new System.Drawing.Point(2, 206);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(225, 47);
            this.filePanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(59, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(5, 17);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(50, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(171, 17);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(50, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(115, 17);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(50, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // sceneLabel
            // 
            this.sceneLabel.AutoSize = true;
            this.sceneLabel.Location = new System.Drawing.Point(3, 2);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(35, 12);
            this.sceneLabel.TabIndex = 0;
            this.sceneLabel.Text = "Scene";
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.changeViewAnimationCheckBox);
            this.viewPanel.Controls.Add(this.nextViewButton);
            this.viewPanel.Controls.Add(this.previousViewButton);
            this.viewPanel.Controls.Add(this.parallelRadio);
            this.viewPanel.Controls.Add(this.perspectiveRadio);
            this.viewPanel.Controls.Add(this.rightViewButton);
            this.viewPanel.Controls.Add(this.leftViewButton);
            this.viewPanel.Controls.Add(this.topViewButton);
            this.viewPanel.Controls.Add(this.frontViewButton);
            this.viewPanel.Controls.Add(this.viewLabel);
            this.viewPanel.Location = new System.Drawing.Point(2, 11);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(225, 110);
            this.viewPanel.TabIndex = 0;
            // 
            // changeViewAnimationCheckBox
            // 
            this.changeViewAnimationCheckBox.AutoSize = true;
            this.changeViewAnimationCheckBox.Location = new System.Drawing.Point(124, 90);
            this.changeViewAnimationCheckBox.Name = "changeViewAnimationCheckBox";
            this.changeViewAnimationCheckBox.Size = new System.Drawing.Size(78, 16);
            this.changeViewAnimationCheckBox.TabIndex = 9;
            this.changeViewAnimationCheckBox.Text = "Animation";
            this.changeViewAnimationCheckBox.UseVisualStyleBackColor = true;
            this.changeViewAnimationCheckBox.CheckedChanged += new System.EventHandler(this.changeViewAnimationCheckBox_CheckedChanged);
            // 
            // nextViewButton
            // 
            this.nextViewButton.Location = new System.Drawing.Point(4, 81);
            this.nextViewButton.Name = "nextViewButton";
            this.nextViewButton.Size = new System.Drawing.Size(104, 23);
            this.nextViewButton.TabIndex = 8;
            this.nextViewButton.Text = "Next View";
            this.nextViewButton.UseVisualStyleBackColor = true;
            this.nextViewButton.Click += new System.EventHandler(this.nextViewButton_Click);
            // 
            // previousViewButton
            // 
            this.previousViewButton.Location = new System.Drawing.Point(4, 50);
            this.previousViewButton.Name = "previousViewButton";
            this.previousViewButton.Size = new System.Drawing.Size(104, 23);
            this.previousViewButton.TabIndex = 7;
            this.previousViewButton.Text = "Previous View";
            this.previousViewButton.UseVisualStyleBackColor = true;
            this.previousViewButton.Click += new System.EventHandler(this.previousViewButton_Click);
            // 
            // parallelRadio
            // 
            this.parallelRadio.AutoSize = true;
            this.parallelRadio.Location = new System.Drawing.Point(124, 68);
            this.parallelRadio.Name = "parallelRadio";
            this.parallelRadio.Size = new System.Drawing.Size(71, 16);
            this.parallelRadio.TabIndex = 6;
            this.parallelRadio.Text = "Parallel";
            this.parallelRadio.UseVisualStyleBackColor = true;
            this.parallelRadio.CheckedChanged += new System.EventHandler(this.projectionRadio_CheckedChanged);
            // 
            // perspectiveRadio
            // 
            this.perspectiveRadio.AutoSize = true;
            this.perspectiveRadio.Checked = true;
            this.perspectiveRadio.Location = new System.Drawing.Point(124, 47);
            this.perspectiveRadio.Name = "perspectiveRadio";
            this.perspectiveRadio.Size = new System.Drawing.Size(89, 16);
            this.perspectiveRadio.TabIndex = 5;
            this.perspectiveRadio.TabStop = true;
            this.perspectiveRadio.Text = "Perspective";
            this.perspectiveRadio.UseVisualStyleBackColor = true;
            this.perspectiveRadio.CheckedChanged += new System.EventHandler(this.projectionRadio_CheckedChanged);
            // 
            // rightViewButton
            // 
            this.rightViewButton.Location = new System.Drawing.Point(171, 17);
            this.rightViewButton.Name = "rightViewButton";
            this.rightViewButton.Size = new System.Drawing.Size(50, 23);
            this.rightViewButton.TabIndex = 4;
            this.rightViewButton.Text = "Right";
            this.rightViewButton.UseVisualStyleBackColor = true;
            this.rightViewButton.Click += new System.EventHandler(this.rightViewButton_Click);
            // 
            // leftViewButton
            // 
            this.leftViewButton.Location = new System.Drawing.Point(115, 17);
            this.leftViewButton.Name = "leftViewButton";
            this.leftViewButton.Size = new System.Drawing.Size(50, 23);
            this.leftViewButton.TabIndex = 3;
            this.leftViewButton.Text = "Left";
            this.leftViewButton.UseVisualStyleBackColor = true;
            this.leftViewButton.Click += new System.EventHandler(this.leftViewButton_Click);
            // 
            // topViewButton
            // 
            this.topViewButton.Location = new System.Drawing.Point(59, 17);
            this.topViewButton.Name = "topViewButton";
            this.topViewButton.Size = new System.Drawing.Size(50, 23);
            this.topViewButton.TabIndex = 2;
            this.topViewButton.Text = "Top";
            this.topViewButton.UseVisualStyleBackColor = true;
            this.topViewButton.Click += new System.EventHandler(this.topViewButton_Click);
            // 
            // frontViewButton
            // 
            this.frontViewButton.Location = new System.Drawing.Point(3, 17);
            this.frontViewButton.Name = "frontViewButton";
            this.frontViewButton.Size = new System.Drawing.Size(50, 23);
            this.frontViewButton.TabIndex = 1;
            this.frontViewButton.Text = "Front";
            this.frontViewButton.UseVisualStyleBackColor = true;
            this.frontViewButton.Click += new System.EventHandler(this.frontViewButton_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(3, 2);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(29, 12);
            this.viewLabel.TabIndex = 0;
            this.viewLabel.Text = "View";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.selectionGroup);
            this.panel2.Controls.Add(this.detailPanel);
            this.panel2.Controls.Add(this.viewPanel);
            this.panel2.Controls.Add(this.shadingGroup);
            this.panel2.Controls.Add(this.filePanel);
            this.panel2.Controls.Add(this.videoPanel);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(230, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 509);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.model);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(878, 509);
            this.splitContainer.SplitterDistance = 636;
            this.splitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(878, 531);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(894, 570);
            this.Name = "MainForm";
            this.Text = "Blind";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.shadingGroup.ResumeLayout(false);
            this.shadingGroup.PerformLayout();
            this.selectionGroup.ResumeLayout(false);
            this.selectionGroup.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private devDept.Eyeshot.Model model;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button frontViewButton;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.RadioButton parallelRadio;
        private System.Windows.Forms.RadioButton perspectiveRadio;
        private System.Windows.Forms.Button rightViewButton;
        private System.Windows.Forms.Button leftViewButton;
        private System.Windows.Forms.Button topViewButton;
        private System.Windows.Forms.Button nextViewButton;
        private System.Windows.Forms.Button previousViewButton;
        private System.Windows.Forms.CheckBox changeViewAnimationCheckBox;
        private System.Windows.Forms.RadioButton hiddenLinesShadingRadio;
        private System.Windows.Forms.RadioButton renderedShadingRadio;
        private System.Windows.Forms.RadioButton shadedShadingRadio;
        private System.Windows.Forms.RadioButton wireframeShadingRadio;
        private System.Windows.Forms.RadioButton flatShadingRadio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Label sceneLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Button videoStartButton;
        private System.Windows.Forms.Button videoStopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Button exportDetailButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox boundingBoxButton;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox volumnTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.GroupBox selectionGroup;
        private System.Windows.Forms.RadioButton pickSelectionRadio;
        private System.Windows.Forms.RadioButton boxSelectionRadio;
        private System.Windows.Forms.RadioButton encloseSelectionRadio;
        private System.Windows.Forms.RadioButton noneSelectionRadio;
        private System.Windows.Forms.GroupBox shadingGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button animationStartButton;
        private System.Windows.Forms.Button animationStopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

