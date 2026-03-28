namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            UIHealthBar ui = new UIHealthBar();
            SoundSystem sound = new SoundSystem();
            AchievementSystem achievements = new AchievementSystem();
            GameLogger logger = new GameLogger();

            player.OnDamageReceived += ui.UpdateBar;
            player.OnDamageReceived += sound.PlaySounds;
            player.OnDamageReceived += achievements.CheckAchievements;
            player.OnDamageReceived += logger.LogDamage;

            player.TakeDamage(15); 
            player.TakeDamage(40); 
            player.TakeDamage(30); 
            player.TakeDamage(20); 

            Console.WriteLine("\nГра завершена. Натисніть клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
