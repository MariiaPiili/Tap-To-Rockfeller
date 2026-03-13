# Tap to Rockefeller

"Tap to Rockefeller" is a small clicker-style game prototype built with Unity and C#.  
The project is inspired by the popular tap-to-earn genre (for example games like Hamster Kombat), where players generate virtual currency by tapping and upgrading their income sources.

The main goal of this project was to explore the core mechanics behind clicker games, including tapping systems, upgrade shops, passive income generation and simple level progression.

This project is part of my portfolio as a **Junior Unity / C# Developer**.

---

# Gameplay

In "Tap to Rockefeller" the player earns coins by tapping the main button.  
Coins can then be used to purchase upgrades that increase:

• coins earned per click  
• passive income per second  

As the player continues tapping and upgrading, they progress through levels that represent their path toward becoming a "Rockefeller".

The gameplay loop is simple but demonstrates the key mechanics behind incremental / idle games.

---

# Features

• Tap to earn coins  
• Passive coin generation per second  
• Upgrade shop system  
• Level progression with progress bar  
• Simple UI animations and feedback  
• Upgrade system affecting gameplay economy  

---

# Game Mechanics

### Tap System
The player taps a button to earn coins.  
Each tap increases the player's coin balance.

### Passive Income
Upgrades allow the player to earn coins automatically every second.

### Upgrade Shop
The player can purchase upgrades that increase:

• coins per click  
• coins per second

Each upgrade improves the player's income efficiency.

### Level Progression
Player levels increase based on the total number of taps.  
A progress bar visualizes the player's advancement to the next level.

---

# Technical Implementation

The project is built using Unity with a focus on simple, modular scripts.

Main systems implemented in the project include:

### Coin System
Handles:

• total coin balance  
• coins gained per click  
• passive income per second  
• UI updates for coin display

### Level System
Tracks player taps and calculates level progression based on predefined thresholds.

### Shop System
Allows the player to purchase upgrades that modify gameplay values.

### Animation System
Basic UI animation triggered on player interaction.

---

# Scripts Overview

**CoinCount**

Manages the main currency system:
- adding coins per tap
- passive coin generation
- handling upgrade effects
- updating UI elements

**LevelManager**

Controls player level progression and progress bar filling based on tap count.

**ShopItem**

Represents an item in the upgrade shop and applies upgrades when purchased.

**TapScript**

Triggers the tap animation when the player interacts with the main button.

---

# Technologies Used

• Unity  
• C#  
• TextMeshPro  
• Unity UI (Canvas system)  

---

# Possible Future Improvements

• save / load system  
• balancing the upgrade economy  
• sound effects and feedback  
• mobile build optimization  
• improved UI and visual polish  

---

# Author

Maria Piili  

Junior Unity / C# Developer  

