using System;

namespace ConsoleApp3
{
   
    public delegate void ButtonClickHandler();

    class Button
    {
        
        public event ButtonClickHandler OnClick;

        public string Label { get; set; }

        public Button(string label)
        {
            Label = label;
        }

        
        public void Click()
        {
            Console.WriteLine($"🔘 Button '{Label}' clicked!");
            OnClick?.Invoke(); 
        }
    }
}
