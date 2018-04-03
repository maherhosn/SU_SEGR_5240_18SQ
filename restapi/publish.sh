docker login
docker tag <image> mjmiller/su_segr:restapi
docker push mjmiller/su_segr:restapi

to run

docker run -p 0.0.0.0:5000:5000 mjmiller/su_segr:restapi
