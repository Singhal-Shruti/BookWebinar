    using Microsoft.JSInterop;
    using System.Threading.Tasks;
    using System;

    public class Webinar
    {
        private readonly IJSRuntime jsRuntime;

        public Webinar(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public Webinar(DateTime date, string eventName){
            this.Date = date;
            this.EventName = eventName;
        }

        public Webinar(){
            
        }
        public DateTime Date { get; set; }

        public string EventName { get; set; }

        public int NumberOfParticipants {get; set;}

        public async Task AddParticipant(){
            NumberOfParticipants++;
            await jsRuntime.InvokeVoidAsync("Alert", "hello");
        }
    }