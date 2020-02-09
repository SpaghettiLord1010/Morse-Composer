import sys
import midiutil
import fileinput
import os
from midiutil.MidiFile import MIDIFile

#Please note that you need to have a version of Python3 installed - herefore just downlaod and install from the web! You need to install Python with the "PIP" option enabled.
#PIP enables you to easily install a library onto your pc, you don't have to worry about shenanigans :)
#You will need the MIDIUtil library - please press the Windows-Key and write "cmd.exe" then you want to write "pip install MIDIUtil" this will take a few moments but it's needed.
#When MIDIUtil is installed you can proceed to use MorseComposer normally and the functionality of exporting to .mid files will be enabled!


# create your MIDI object
mf = MIDIFile(1)     # only 1 track
track = 0   # the only track
time = 0    # start at the beginning
mf.addTrackName(track, time, "Sample Track")
mf.addTempo(track, time, 120)

#Setting up Channel and Volume
channel = 0
volume = 100

#26 is D1 then it goes on until 108 (C8 - max!)
#start of my loop
i = 0
for line in fileinput.input(str(os.getenv('APPDATA')) + "\\MorseComposer\\temp.txt"):
    if i==0:
        pitch = line
        i = i+1
    elif i==1:
        time = line
        i = i+1
    elif i==2:
        duration = line
        i = i+1
    elif i==3:
        mf.addNote(track, channel, int(pitch), int(time), int(duration), volume)
        pitch = 0
        time = 0
        duration = 0
        i = 0

#Creating the dir if not there
if not os.path.exists(str(os.getenv('APPDATA')) +  "\\MorseComposer\\"):
    os.makedirs(str(os.getenv('APPDATA')) + "\\MorseComposer\\")

# write it to disk
with open(str(os.getenv('APPDATA')) +  "\\MorseComposer\\MorseComposerOutput.mid", 'wb') as outf:
    mf.writeFile(outf)
