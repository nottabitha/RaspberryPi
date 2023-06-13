using System.Device.Gpio;

namespace BlinkTutorial
{
    public class Blink
    {
        public static async Task BlinkMillisecond(int ms, int pin)
        {
            Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
            using var controller = new GpioController();
            controller.OpenPin(pin, PinMode.Output);
            bool ledOn = true;
            while (true)
            {
                controller.Write(pin, ledOn ? PinValue.High : PinValue.Low);
                await Task.Delay(ms);
                ledOn = !ledOn;
            }
        }
    }
}


