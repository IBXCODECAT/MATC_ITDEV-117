namespace com.schmitt.assignment7
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            MagazineSubscription i_sub0 = new MagazineSubscription();
            MagazineSubscription i_sub1 = new MagazineSubscription();

            i_sub0.setSubscriberName("Bobby Bobswell");
            i_sub0.setMagazineName("Bob goes boom!");
            i_sub0.setMonthsRemaining(7);

            i_sub1.setSubscriberName("John Doe");
            i_sub1.setMagazineName("The little doe john");
            i_sub1.setMonthsRemaining(3);

            Console.Write("Name: " + i_sub0.getSubscriberName());
            Console.Write("\t\t");
            Console.Write("Magazine: " + i_sub0.getMagazineName());
            Console.Write("\t\t");
            Console.Write("Months: " + i_sub0.getMonthsRemaining());
            Console.Write("\n\r");

            Console.Write("Name: " + i_sub1.getSubscriberName());
            Console.Write("\t\t\t");
            Console.Write("Magazine: " + i_sub1.getMagazineName());
            Console.Write("\t\t");
            Console.Write("Months: " + i_sub1.getMonthsRemaining());
            Console.Write("\n\r");
        }
    }
}