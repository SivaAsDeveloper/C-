using System;
using Microsoft.AspNetCore.Components;
namespace BlazorLearningKickOff.Components
{
    public partial class DismissableAlert
    {
        private bool show =true;
        [Parameter]
       public bool Show { get => this.show;
        set{
            if(value!=this.show)
            {
                this.show=value;
                ShowChanged?.Invoke(this.show);
            }
        }
     } 
       [Parameter]
       public RenderFragment ChildContent { get; set; }
       public void Dismiss()=>Show=false;
       [Parameter]
       public Action<bool> ShowChanged { get; set; }
    }
}