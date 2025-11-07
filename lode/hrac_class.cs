namespace lode
{
    internal class Hrac
    {
        int budget;
        PoleHrace mojePlocha;
        public Hrac(int vel, int buget)
        {
            this.budget = buget;
            this.mojePlocha = new PoleHrace(vel);
        }
    }
}
