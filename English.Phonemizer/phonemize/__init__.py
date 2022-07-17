from phonemizer import phonemize

import json
import azure.functions as func

def main(req: func.HttpRequest) -> func.HttpResponse:
    headers = {"Access-Control-Allow-Origin": "*", "Access-Control-Allow-Headers": "*"}

    if req.method == "OPTIONS":
        return func.HttpResponse(headers=headers)
    else:
        request_data = req.get_json()
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
        json_body = json.dumps(response_body)
        
        return func.HttpResponse(body=json_body, headers=headers)