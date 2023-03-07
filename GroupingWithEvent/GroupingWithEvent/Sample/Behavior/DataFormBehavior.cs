using Syncfusion.Maui.DataForm;

namespace GroupingWithEvent
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
            dataForm.RegisterEditor("Prefix", DataFormEditorType.Picker);
            dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
        }
        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.FieldName == "FirstName" || e.DataFormItem.FieldName == "LastName")
                {
                    e.DataFormItem.GroupName = "Name";
                }
                else if (e.DataFormItem.FieldName == "Address" || e.DataFormItem.FieldName == "City" || e.DataFormItem.FieldName == "Country")
                {
                    e.DataFormItem.GroupName = "Details";
                }
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            if (dataForm != null)
            {
                dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
            }

            dataForm = null;
        }
    }
}