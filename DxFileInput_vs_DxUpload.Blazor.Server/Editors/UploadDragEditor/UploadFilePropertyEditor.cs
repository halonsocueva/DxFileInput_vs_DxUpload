using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DxFileInput_vs_DxUpload.Module.BusinessObjects;

namespace TszWeb.Blazor.Server.Editors.UploadDargEditor
{
    [PropertyEditor(typeof(FileData), "FileInputEditor", false)]
    public class UploadFilePropertyEditor : BlazorPropertyEditorBase, IComplexViewItem
    {
        BlazorApplication Application;
        IObjectSpace ObjectSpace;

        public UploadFilePropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

        protected override IComponentAdapter CreateComponentAdapter()
        {
            return new UploadFileAdapter(new UploadFileModel( ((BaseObject)CurrentObject).Oid, (Document)CurrentObject, ObjectSpace, Application));
        }

        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            Application = application as BlazorApplication;
            ObjectSpace = objectSpace;
        }
    }
}
