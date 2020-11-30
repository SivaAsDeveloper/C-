using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace PizzaPlace.Client.Pages
{
    public class InputWatcher: ComponentBase
    {
        private EditContext editContext;
        [CascadingParameter]
        public EditContext EditContext{
            get => this.editContext;
            set{
                this.editContext=value;
                this.EditContext.OnFieldChanged+= async (seder,e)=>
                {
                    await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
                };
            }
        }
        [Parameter]
        public EventCallback<string> FieldChanged{get;set;}
        public bool Validate()=> this.EditContext?.Validate() ?? false;
        
    }
}