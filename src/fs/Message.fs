module Message

open Fable.Core.JsInterop

let message = importMember<string> "../js/Message.js"

let EOL = importMember<string> "os"
