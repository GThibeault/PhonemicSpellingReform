FROM mcr.microsoft.com/azure-functions/python:4-python3.9

ENV LANG=C.UTF-8 LC_ALL=C.UTF-8

# set the working directory to /phonemizer
WORKDIR /phonemizer

# install dependencies
RUN apt-get update && apt-get upgrade -y && apt-get install -y \
    festival \
    festlex-cmu \
    festlex-poslex \
    espeak-ng \
    git \
    python3 \
    python3-pip && \
    apt-get clean

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY requirements.txt /
RUN pip install -r /requirements.txt

COPY . /home/site/wwwroot