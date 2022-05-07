from flask import request
from flask_cors import CORS, cross_origin
from . import app
from phonemizer import phonemize

cors = CORS(app)
app.config["CORS_HEADERS"] = "Content-Type"


@app.route("/phonemize", methods=["POST"])
@cross_origin()
def phonemize_handler():
    request_data = request.get_json()
    phonemized = phonemize(
        request_data["text"],
        language='en-us',
        preserve_empty_lines=True,
        preserve_punctuation=True,
        with_stress=True,
    )

    return {"phonemized": phonemized}
