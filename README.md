# EndRoundFriendlyFireNW
Plugin offers FriendlyFire with Hint/Broadcast to players. 


![EndRoundFriendlyFireNW ISSUES](https://img.shields.io/github/issues/Undid-Iridium/EndRoundFriendlyFireNW)
![EndRoundFriendlyFireNW FORKS](https://img.shields.io/github/forks/Undid-Iridium/EndRoundFriendlyFireNW)
![EndRoundFriendlyFireNW LICENSE](https://img.shields.io/github/license/Undid-Iridium/EndRoundFriendlyFireNW)


![EndRoundFriendlyFireNW LATEST](https://img.shields.io/github/v/release/Undid-Iridium/EndRoundFriendlyFireNW?include_prereleases&style=flat-square)
![EndRoundFriendlyFireNW LINES](https://img.shields.io/tokei/lines/github/Undid-Iridium/EndRoundFriendlyFireNW)
![EndRoundFriendlyFireNW DOWNLOADS](https://img.shields.io/github/downloads/Undid-Iridium/EndRoundFriendlyFireNW/total?style=flat-square)

TODO:
* Add more configuration for locked values
* Allow ignoring of fields for format string
* Add the ability for fully customizable strings where I list variables that can be called, and then you can build your own combination of stats. 
* (The previous one would be strings that users can reference and I would parse them to generate unique strings)

# Installation

**[NWAPI](https://github.com/northwood-studios/NwPluginAPI) must be installed for this to work.**

Current plugin version: V1.0.0 

## REQUIREMENTS
* NWAPI: V12.0.0-RC.2
* SCP:SL Server: V12

Example configuration
```
is_enabled: true
# Whether debug logs should be shown.
debug: true
# Overrides ConfigFile FriendlyFireMultiplier (or you can do it there).
overridden_friendly_fire_multiplier: 0.300000012
# Sets the message players will get when friendly fire is turned on
message: <align=center><voffset=28em> <color=#F6511D> Friendly Fire has been enabled! </color></voffset></align>
# The message type for notifying players, broadcast / hint
friendly_fire_notifying_type: Hint
# How long to display FF message
message_duration: 15
 ```

User example: 
![image](https://user-images.githubusercontent.com/24619207/207770776-2f27db51-1994-43cb-aaac-ddcf9657068f.png)


