# Windows Title Changer

[DOWNLOAD HERE](http://github.com/hernanex3/WindowsTitleChanger/releases)

Continuously changes the titles of windows. You configure a file `config.txt`, where the fist line is the executable name
and the second the desired title name. You can edit it without restarting the software to see the instant change.
In the next example I edited the windows title of the `code` program to `vs code power`.

![demo](/demo.gif)

If you don't know how your process are called open the `cmd` and type `tasklist`

My use case was that I needed to ensure that certain apps have always the same
name to let obs detect the focus correctly. For example firefox may change
the windows name every time you change tabs, this makes life very difficult
while streaming.