# Coding Philosophy

We'll be using both the Western (Sillicon Valley) and Japanese (Toyotta)
philosophies for this

## Structuring

Directories with separation of concerns and sub-directories with their
respective specific concern like so:


## Development cycle

1. Planning

   Write down what the goal is, and what is needed to be done to get there.

1. Designing

   Sketch a diagram of flow

1. Build

   Small iterations that does what's needed

1. Test

   Unit test + integrations tests early

1. Refactor

   Once the code is working, refactor it to improve your code.
   When the code needs to be expanded, go through steps 3-5 again with the new
   code.

1. Documentation

   Self-documenting code might not be enough, sometimes comments explaining
   business logic will be needed. Update documentation as needed as code gets
   updated.

1. Release

   Automate deployment

## Monozokuri - The Art, Science and Craft of making things

- Value in craftsmanship
- Pride in workmanship
- Kaizen (continuous improvement, improve 1% daily)
- Treating code as a long-lasting artifact rather than a temporary feature

## Practices

- Just-in-Time Development

  Build only what's needed now, no need to overoptimize, over engineer, etc
  something that might not even be used.

  Expand it as needed

- Jidoka principle

  Everyone involved must halt their work to focus on fixing bugs before moving
  on.

  This avoids technical debt, the normalization of bugs, helps everyone write
  better code altogether and makes coding collectively easier and faster.

- Hansei

  A ritual of reflection, where everyone will come together to discuss what
  went right and what went wrong, learn what worked, acknowledge mistakes and
  come to solutions to avoid it in the future, this can be done weekly, or
  more/less depending on importance or frequency of problems.

## Code Quality and Style

- Consistent, clear, descriptive variable, constants, function, etc names

  By naming your code coherently it reduces time and energy needed to figure
  out the code. This might apply even to your own code which you didn't touch
  four a couple weeks/months.

- Wabi-sabi (embrace imperfection)

  Your code doesn't have to be perfect, just code what needs to be done now,
  fix the bugs and improve on it over time.

  Thinking about all the possibilities takes too much time, you'll never
  be able to "predict" every scenario and, some scenarios might never happen.

## Code Review

- Code reviews are deliberate and thorough

  Pull requests doesn't have to take days to be merged but requires attention
  and some time to check if it's working and not having some negative impact
  somewhere else.

  Reliable code reduces chances of pretty much all negative outcomes that
  might come from an unreliable code, users leaving, subscribers looking for
  better alternatives, even avoiding lawsuits in some cases.

## Testing

- Use Test-Driven Development methodology
- Write test for business logic
- Use integration tests for systems communication
- Coverage must be only what's needed for now, increase as needed
- Ensure rock-solid foundation before release

## Documentation

Keep a /docs folder (such as the one this file is currently in) with README,
architecture (structure overview), decisions (important choices and why), create
subdirectories if/when needed.

"Leave it better than you found it."
