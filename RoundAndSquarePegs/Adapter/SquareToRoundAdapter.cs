using RoundAndSquarePegs.Pegs;

namespace RoundAndSquarePegs.Adapter
{
    internal class SquareToRoundAdapter : IRoundPegAdapter
    {
        private SquarePeg _squarePeg;

        public SquareToRoundAdapter(SquarePeg squarePeg)
        {
            _squarePeg = squarePeg;
        }

        public RoundPeg ToRoundPeg()
        {
            double radius = _squarePeg.Size * Math.Sqrt(2) / 2;
            return new RoundPeg(radius);
        }
    }
}
