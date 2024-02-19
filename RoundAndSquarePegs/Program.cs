using RoundAndSquarePegs.Adapter;
using RoundAndSquarePegs.Holes;
using RoundAndSquarePegs.Pegs;

RoundHole hole = new(5);
RoundPeg roundPeg = new(4);
RoundPeg roundPeg2 = new(8);
SquarePeg squarePeg = new(4);

//In a real system, it might have been better to create a Factory responsible for Adapter creation
//algo having all Pegs inheriting from a super class Peg, so the client code is unaware of specific Peg implementations
IRoundPegAdapter adapter = new SquareToRoundAdapter(squarePeg);
var roundPeg3 = adapter.ToRoundPeg();

Console.WriteLine($"Round peg 1, with radius {roundPeg.Radius}: {hole.Fits(roundPeg)}");
Console.WriteLine($"Round peg 2, with radius {roundPeg2.Radius}: {hole.Fits(roundPeg2)}");
Console.WriteLine($"Square peg, converted to round peg with radius {roundPeg3.Radius}: {hole.Fits(roundPeg3)}");