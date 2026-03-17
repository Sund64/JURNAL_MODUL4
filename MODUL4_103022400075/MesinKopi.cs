using System;
public class MesinKopi
{
    enum State {STANDBY, OFF, BREWING, MAINTENANCE };
    public enum Trigger { POWER_ON, POWER_OFF, START_BREW, FINISH_BREW, START_MAINTENANCE, FINISH_MAINTENANCE }

    public void activateTrigger(Trigger trigger)
    {

        State state = State.STANDBY;
        while (state != State.MAINTENANCE)
        {

            switch (state)
            {
                case State.STANDBY:
                    if (trigger == Trigger.POWER_OFF)
                    {
                        state = State.OFF;
                        Console.Write("Mesin Standby berubah menjadi Off");
                    }
                    else if (trigger == Trigger.START_BREW)
                    {
                        state = State.BREWING;
                        Console.Write("Mesin Standby berubah menjadi Brewing");
                    }
                    else if (trigger == Trigger.START_MAINTENANCE)
                    {
                        state = State.MAINTENANCE;
                        Console.Write("Mesin Standby berubah menjadi Maintenance");
                    }
                    else
                        Console.Write("Perubahan State Tidak Valid");
                    break;
                case State.OFF:
                    if (trigger == Trigger.POWER_ON)
                    {
                        state = State.STANDBY;
                        Console.Write("Mesin Off berubah menjadi Standby");
                    }
                    else
                        Console.Write("Perubahan State Tidak Valid");
                    break;
                case State.BREWING:
                    if (trigger == Trigger.FINISH_BREW)
                    {
                        state = State.STANDBY;
                        Console.Write("Mesin Brewing berubah menjadi Standby");
                    }
                    else
                        Console.Write("Perubahan State Tidak Valid");
                    break;
                case State.MAINTENANCE:
                    if (trigger == Trigger.FINISH_MAINTENANCE)
                    {
                        state = State.STANDBY;
                        Console.Write("Mesin Maintenance berubah menjadi Standby");
                    }
                    else
                        Console.Write("Perubahan State Tidak Valid");
                    break;
            }
            break;
        }
        Console.WriteLine();

    }
}