# Morse-Composer: What is it?

Welcome to the (I think) world's first ever application that allows you to easily create .mid files from Morse Code!
It is easy, you enter some text, let the program translate it and now there comes the important part:
Morse Code can be understood only by rhythm so you can use it to make melodies and or hidden messages in songs or whatever!


## How do I use it?

### Version 1.2 introduced a feature that allows you to let the program automatically set the delays, this way you can just focus on the melody!

You just type in your word or sentence and click on the edit button, now you can change the tone of each individual dot or dash, you can adjust the delay to your liking but there is an international standard in Morse Code:

A dot is one unit, a dash is three units.
The normal delay between sounds in one character is one unit.
The space between characters is 3 units.
The space between words is 7 units.


## Do I need to follow these rules exactly in order to understand it?

It is much easier to understand when you follow those standards, but it isn't necessarily needed to understand Morse Code.
A person that knows Morse Code should be able to understand most of the things, but if you have no delay between beeps, it can be a real challenge, so I strongly suggest that you follow the standard.

## Tips to get started:

### You can now use the automatic-delay-mode to make things easy!

Let's suppose, you have clicked on edit and now you want to adjust the code:

In each character there are multiple symbols, either a dot or a dash, of each of those symbols you can adjust the tone (how high or low a note is) and the delay (how long to wait after the start of the previous symbol).
If you want the midi to start right at the beginning, you have to set the delay to 0 - the delay from the first note should be nothing, if there was a previous note, they would overlap, we don't want that.

### This is the case, that we start with a dot - one unit long.
For the second note, you would put a delay of 2 to play it one beat after the first note, that one beat delay is the standard.
But why put a delay of 2 you ask? Mid files store notes with a starting time, a lenght and a tone (and more but that is more technical and not available in this program right now). The delay gets added to the start time of the first beep, in our case, the first one was at 0, so right at the beginning! If we typed in a delay of 1 the scond note would start directly after the first note because our first note was a dot which is one unit long.
(If you had a dash as the first note you would need to set it to 4!)

## Other Info

### Special Thanks and general info
Thanks to @Scrivener07 and @DaGammla for helping me with this project!
I decided to put it in the Unilicense so that everyone can use and build upon this project, it helped me to learn some new stuff too and I think it should continue to help others to learn.

I hope you like it, make some cool music!


### Ideas for the future:

- [x] Set the delay automatically to work with the standard. - A little tedious to wrap the head around but done!

Empty here, but it is working superb and as intended!
