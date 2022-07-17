docker build --pull --rm -f "Dockerfile" -t phonemizer:latest "." && docker rm phonemizer && docker run -p 8000:80 --name "phonemizer" -it phonemizer:latest

docker build --pull --rm -f "Dockerfile" -t phonemizer:latest "." 
docker rm phonemizer 
docker run -p 8000:80 --name "phonemizer" -it phonemizer:latest