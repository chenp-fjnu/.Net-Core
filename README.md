This project is following the AspNetCore wiki to create one demo project.

https://docs.asp.net/en/latest/intro.html

https://docs.microsoft.com/zh-cn/dotnet/articles/core/index

* Request: http://localhost:5000/api/users/3
* Output: {"id":3,"name":"Name:3","sex":"Male"}

***
#dotnet Commands:
* dotnet build
* dotnet run
* dotnet test
* dotnet restore

***
#Docker 
## Wiki:
* https://yeasy.gitbooks.io/docker_practice/content/dockerfile/index.html

## Commands:
* docker images
* docker ps
* docker run [imagename]
    * Samples:
        * docker run hello-world
        * docker run -it ubuntu bash
        * docker run -d -p 80:80 --name webserver nginx
* docker build -t [imagename] .
> imagename should be lowercase!!!
    * Samples:
        * docker build -t webapiframe .
* docker tag [imageid] [dockeraccount]/[imagename]:[version]
    * Samples:
        * docker tag 7d9495d03763 pc45025/webapiframe:latest
* docker login --username=[dockeraccount] --email=[dockeraccount_mail]
* docker push [dockeraccount]/[imagename]
    * Samples: 
        * docker push pc45025/webapiframe
* docker rmi -f [imageid]|[imagename]
    * Samples:
        * docker rmi -f 7d9495d03763
        * docker rmi -f docker-whale