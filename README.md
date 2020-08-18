# blind

**A simple 3D model display and interaction engine**


blind是基于eyeshot开发的简单的三维引擎，具备最基本的三维模型显示和交互功能


## 功能介绍
### 1.交互功能
- 鼠标交互功能，如旋转、平移、缩放等
- 视角转换功能，如俯视图，正试图
- 导入/导出 stl、step、obj、3ds、asc、iges等模型的功能
- 视图转换功能，如渲染视图、线框视图等

### 2.视频录制
- blind可以录制模型场景视频
- blind默认导入的吊扇模型具有动画效果

### 3.信息概括
- 显示几何模型的包围盒，表面积以及体积
- 生成html格式图文报告，场景截图和表格格式的模型信息，内容有模型实体数，顶点数，三角片数、表面积以及体积


## To Run it
1. **克隆项目到本地**
2. **将/blind/dll下的 a\*.dll , p\*.dll , s\*.dll拷贝至/blind/bin/Debug或/blind/bin/Release中**
3. **打开Visual Studio，将/blind/dll下的AForge\*.dll添加至引用**
4. **启动**


> 注意
> * 视频及报告生成目录为/blind/bin/Debug或/blind/bin/Release
> * 由于eyeshot貌似没有获取三维场景图片的接口(或者我没找到)，故录制视频采用的是从屏幕固定区域截屏获取帧的方法
因此录制视频的时候请确保程序在最上层
> * 当进行Selection的时候，按右键可进行模型的交互，再次按右键可应用交互，ESC可取消




