# How To Use

## Remove And Install New Version

## Initialize

## Run Api Server

## Run In Docker
```
docker run -d \
   -e ASPNETCORE_URLS="http://\*:8080" -e ASPNETCORE_ENVIRONMENT=prod \
   -p 8103:8080 \
   --name notify2-api \
   -v /var/project/notify2/api/appsettings.json:/app/appsettings.json \
   -v /var/project/notify2/api/secrets.json:/app/secrets.json \
   -v /var/project/notify2/api/Localization:/app/Localization \
   -v /var/project/notify2/static:/app/static \
   notify2-api
```
