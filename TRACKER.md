\# Outland Extraction — Tracker



Living progress tracker. Update as you go. See DESIGN.md for the full design.



\---



\## ✅ Done

\- Git / GitHub setup (repo, gitignore, commit/push workflow)

\- Player movement (continuous, store-and-apply)

\- Camera look (FPS yaw/pitch, pivot rig)

\- Shooting — projectile (bullet owns flight, gun launches), straight flight

\- Raycast-the-path hit detection (+ ft-lbs energy calc)

\- Combat core: enemy chase, HealthSystem (OnDeath event), IDamageable, DeathHandler, damage-on-hit

\- Crosshair (basic HUD canvas seed) testing only will be gone when ads system is in 

\- Design doc (this)



\## 🔨 Next / Core Loop To-Do (build order)

\- \[ ] Extraction / persistence skeleton — raid scene ↔ safe scene, persist player/inventory/loot/input, reset raid \*(leaning: do early — foundational)\*

\- \[ ] Loot — enemy/container drops item → pickup → inventory

\- \[ ] Inventory (GAMMA bag) — list, category-group, stack, favorites

\- \[ ] Simple hub/screen — sell loot, gear up between raids

\- \[ ] Basic trader economy — sell loot, buy ammo/kits/parts

\- \[ ] Missions/bounty — accept contract, hunt, proof-of-kill, turn in

→ Goal: full rough core loop playable end-to-end.



\## 🎨 Refine (after core loop plays)

\- \[ ] Bullet drop + velocity loss (range damage falloff)

\- \[ ] Camera-aim convergence (hit crosshair)

\- \[ ] Tarkov grid rig inventory

\- \[ ] Weapon find-and-repair economy (parts, tiered kits)

\- \[ ] Better spawning, more content, atmosphere/juice



\## 🧊 Backlog / Dream-tier (way later)

\- See DESIGN.md → Banked Later-Features (zeroing range, notebook, organs, perception AI, penetration/ricochet, etc.)



\---



\## Current focus

\*(update this line each session — what you're working on right now)\*

→ Next: decide extraction-skeleton vs loot, start the next core-loop brick.

