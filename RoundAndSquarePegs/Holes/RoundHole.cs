using RoundAndSquarePegs.Pegs;

namespace RoundAndSquarePegs.Holes
{
    public class RoundHole
    {
        public double Radius { get; set; }

        public RoundHole(double radius)
        {
            Radius = radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return peg.Radius <= Radius;
        }
    }
}
