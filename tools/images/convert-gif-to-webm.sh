#!/bin/bash

for w in ./*.gif; do 
  'F:/Tools/ffmpeg/ffmpeg.exe' -i $w -c vp9 -b:v 0 -crf 40 ${w%.*}.webm && rm $w 
done 