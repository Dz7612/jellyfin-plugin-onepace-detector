# One Pace Detector (Jellyfin Plugin)

One Pace Detector is a Jellyfin metadata plugin that detects One Pace episodes by filename and assigns the correct season, episode number, and title.

Designed for Jellyfin 10.11+ 

## Features

- Detects One Pace episodes by filename
- Automatically assigns season (arc-based)
- Automatically assigns episode number (cut number)
- Sets episode title
- No file renaming or moving
- No external metadata services
- Works on Jellyfin 10.11+
- Local metadata provider (future-proof)

---

## Supported Filename Format

The plugin detects files named like:

[One Pace][1] Romance Dawn 01 [1080p][En Dub][HASH].mp4  
[One Pace][23-25] Syrup Village 01 [1080p][En Dub][HASH].mp4  

---

## Supported Arcs

Romance Dawn  -> Season 1  
Syrup Village -> Season 2  

More arcs can be added.

---

## Installation (Plugin Repository)

1. Open Jellyfin Web UI
2. Go to Dashboard -> Plugins -> Repositories
3. Click Add Repository
4. Paste the following URL:

https://raw.githubusercontent.com/Dz7612/jellyfin-plugin-onepace-detector/refs/heads/main/manifest.json

5. Save and restart Jellyfin

---

## Install the Plugin

1. Go to Dashboard -> Plugins -> Catalog
2. Install "One Pace Detector"
3. Restart Jellyfin

---

## Verify It Works

1. Open a One Pace episode
2. Click the three-dot menu -> Refresh Metadata
3. Check Jellyfin logs for:

OnePaceDetector matched: [One Pace][1] Romance Dawn 01 -> S01E01

If you see this log entry, the plugin is working.

---

## Requirements

- Jellyfin 10.11.x
- Library type: TV Shows
- .NET 9

---

## Notes

- This plugin does not rename or move files
- Filenames must include arc name and cut number
- Designed specifically for One Pace releases

---

## Development

Build the plugin:

dotnet build -c Release

Output directory:

bin/Release/net9.0/

---

## License

MIT
