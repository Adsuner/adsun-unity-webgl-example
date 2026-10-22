# Adsun + Unity WebGL — Telegram Mini App example

Unity `.jslib` bridge plus a C# wrapper to show Adsun ads from a WebGL build.

Add `<script src="https://api.adsun.io/sdk.js"></script>` to your WebGL template's `index.html`.

## Run

Put an object named `AdsunManager` in your scene, attach the script, call `Show()` from a button, then build for WebGL.

Replace `YOUR_BLOCK_ID` with the block ID from your Adsun publisher panel.

## Debug mode

`debug: true` shows a test ad: no billing, and the Reward URL is **not** called.
Use it outside Telegram too (otherwise you get `NoUserData`). Remove it before going live.

## Links

- Docs: https://adsun.io/documentation
- Mini App monetization: https://adsun.io/telegram-mini-app-monetization

## License

MIT
