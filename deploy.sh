#!/bin/sh
. $HOME/.nvm/nvm.sh
ENV="$NODE_ENV";

cd ./api
git pull origin master;

sudo docker build -t notify2-api ./

if [ "$(sudo docker ps -q -f name=notify2-api)" ]; then
   sudo docker stop notify2-api
fi
if [ "$(sudo docker container ls -f name=notify2-api)" ]; then
   sudo docker rm notify2-api
fi
sudo docker run -d \
   -e ASPNETCORE_URLS=http://\*:8080 -e ASPNETCORE_ENVIRONMENT=prod \
   -p 8103:8080 \
   --name notify2-api \
   -v /var/project/notify2/api/appsettings.json:/app/appsettings.json \
   -v /var/project/notify2/api/secrets.json:/app/secrets.json \
   -v /var/project/notify2/api/Localization:/app/Localization \
   -v /var/project/notify2/static:/app/static \
   notify2-api
