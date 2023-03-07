using Syncfusion.Maui.DataForm;

namespace GroupingWithAttribute
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new ItemSourceProvider();
            dataForm.RegisterEditor("Address", DataFormEditorType.MultilineText);
            dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
        }
    }
}