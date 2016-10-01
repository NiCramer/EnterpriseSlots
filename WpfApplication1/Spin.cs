using System;

public class Spin
{

    private int money;
    int rand1;
    int rand2;
    int rand3;
    int winnings;
    int bet = 5;

    public void spin(Wallet wallet)
    {

        Random randNum = new Random();
        money = wallet.money;


        while (money >= 5)
        {

                rand1 = randNum.Next(0, 9);
                rand2 = randNum.Next(0, 9);
                rand3 = randNum.Next(0, 9);
                

                int Value = Convert.ToInt32("" + rand1 + rand2 + rand3);
                String Value2 = Value.ToString("D3");
                

                if (Value == 111)
                {
                    winnings = 0;
                    money = money + 0;
                }
                else if (Value == 222)
                {
                    winnings = (bet * 2);
                    money = money + winnings;
                }
                else if (Value == 333)
                {
                    winnings = (bet * 3);
                    money = money + winnings;
                }
                else if (Value == 444)
                {
                    winnings = (bet * 4);
                    money = money + winnings;
                }
                else if (Value == 555)
                {
                    winnings = (bet * 5);
                    money = money + winnings;
                }
                else if (Value == 666)
                {
                    winnings = (bet * 6);
                    money = money + winnings;
                }
                else if (Value == 777)
                {
                    winnings = (bet * 7);
                    money = money + winnings;
                }
                else if (Value == 888)
                {
                    winnings = (bet * 8);
                    money = money + winnings;
                }
                else if (Value == 999)
                {
                    winnings = (bet * 9);
                    money = money + winnings;
                }
                else if (Value == 000)
                {
                    winnings = (bet * 10);
                    money = money * winnings;
                }
                else if (rand1 == rand2 || rand2 == rand3 || rand3 == rand1)
                {
                    winnings = 2;
                    money = money + winnings;
                }
                else
                {
                    winnings = -5;
                    money = money + winnings;

                }

            }
    }


    public int getRoll1()
    {

        int result = rand1;
        return result;
    }

    public int getRoll2()
    {

        int result = rand2;
        return result;
    }

    public int getRoll3()
    {

        int result = rand3;
        return result;
    }

    public int getWinnings()
    {
        return winnings;
    }



}
