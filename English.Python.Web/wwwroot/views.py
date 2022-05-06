from flask import request
from werkzeug.exceptions import HTTPException
from . import app

from phonemizer import phonemize

@app.route("/phonemize")
def phonemize_handler():
    request_data = request.get_json()
    phonemized = phonemize(request_data["text"])

    return {"phonemized": phonemized}
