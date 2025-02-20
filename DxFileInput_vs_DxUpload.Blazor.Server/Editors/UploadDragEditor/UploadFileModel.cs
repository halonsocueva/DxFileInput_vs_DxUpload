using DevExpress.ExpressApp.Blazor.Components.Models;
using System.Reactive.Subjects;
using System.Reactive;
using System.Reactive.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor;
using DxFileInput_vs_DxUpload.Module.BusinessObjects;

namespace TszWeb.Blazor.Server.Editors.UploadDargEditor
{
    public class UploadFileModel : ComponentModelBase
    {
        internal Subject<Unit> UploadedSubject = new Subject<Unit>();
        public UploadFileModel(Guid guid, Document document, IObjectSpace objectSpace, BlazorApplication application)
        {
            Name = guid.ToString();
            Document = document;
            ObjectSpace = objectSpace;
            Application = application;
        }

        public Document Document { get; set; }
        public BlazorApplication Application { get; set; }
        public IObjectSpace ObjectSpace { get; set; }
        public IObservable<Unit> Uploaded => UploadedSubject.AsObservable();

        public string Value
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }

        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }


        public string Name
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }

        public bool AllowCancel
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }
        public bool AllowPause
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }

        public void SetValueFromUI(string value)
        {
            SetPropertyValue(value, notify: true, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler ValueChanged;
    }
}
