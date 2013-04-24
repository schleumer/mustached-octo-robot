#!/bin/bash

PWD=$(pwd);

rm $PWD/MustachedOctoRobot/bin/Debug/App
ln -s $PWD/MustachedOctoRobot/App  $PWD/MustachedOctoRobot/bin/Debug/App

xbuild $PWD/MustachedOctoRobot.sln

cd $PWD/MustachedOctoRobot/bin/Debug/

./MustachedOctoRobot.exe
