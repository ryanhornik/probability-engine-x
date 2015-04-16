# Prob to Excel
Recommended reading
 - http://nvie.com/posts/a-successful-git-branching-model/

If you want a GUI tool for git I'd recommend git extensions
 - http://sourceforge.net/projects/gitextensions/

Before you start at all you should clone the repo to a directory seperate from svn and work on it there
```git clone https://github.com/ryanhornik/probtoexcel.git```

Basically when you start working on a use case you should
```
git checkout develop
git branch feature-name
git checkout feature-name
```

When you complete your use case you should just let me know when your done and I'll merge it to develop
