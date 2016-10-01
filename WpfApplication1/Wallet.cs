using System;

public class Wallet
{

    public int money { get; set; }

        public int fillWallet()
        {
            
            money = money + 50;
            return money;
        }

        public int cashOut(int money)
        {
           
            return money;
            
        }
       

        public int getWallet()
        {
            return money;
        }

        public void setWallet(int amount)
        {
            money = amount;
        }

}
