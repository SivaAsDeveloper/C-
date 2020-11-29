using System;
using Microsoft.AspNetCore.Components;
namespace BlazorLearningKickOff.Components
{
    public class Timer:ComponentBase
    {
        [Parameter]
        public double TimeInSeconds { get; set; }
        [Parameter]
        public Action Tick { get; set; }
        protected override void OnInitialized()
        {
            var timer = new System.Threading.Timer(
                callback:(_)=> InvokeAsync(()=> Tick?.Invoke()),
                state:null,
                dueTime:TimeSpan.FromSeconds(TimeInSeconds),
                period:TimeSpan.FromSeconds(TimeInSeconds)

            );
        }

        
    }
}