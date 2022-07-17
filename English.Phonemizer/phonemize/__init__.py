#from flask import request
#from flask_cors import CORS, cross_origin
#from . import app
#from phonemizer import phonemize

#cors = CORS(app)
#app.config["CORS_HEADERS"] = "Content-Type"


#@app.route("/phonemize", methods=["POST"])
#@cross_origin()
#def phonemize_handler():
#    request_data = request.get_json()
#    text, language = request_data["text"], request_data["language"] 
    
#    phonemized = phonemize(
#        text,
#        language= 'en-us' if language is None else language,
#        backend="espeak",
#        preserve_empty_lines=True,
#        preserve_punctuation=True,
#        with_stress=True,
#    )

#    return {"phonemized": phonemized}

from phonemizer import phonemize

import logging
import azure.functions as func

def main(request: func.HttpRequest) -> func.HttpResponse:
    logging.info('Python HTTP trigger function processed a request.')
    
    request_data = request.get_json()
    text, language = request_data["text"], request_data["language"]
    
    phonemized = phonemize(
        text,
        language= 'en-us' if language is None else language,
        backend="espeak",
        preserve_empty_lines=True,
        preserve_punctuation=True,
        with_stress=True,
    )

    response_body = {"phonemized": phonemized}

    return func.HttpResponse(body=response_body)