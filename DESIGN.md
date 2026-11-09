\# Outland Extraction — Design Doc



> A hardcore, atmospheric, systems-deep solo-built extraction shooter.

> Post-Soviet / post-apocalyptic vibe. Hunt: Showdown meets STALKER meets Tarkov — contained, but deep.



\---



\## Vision / Pitch



You take contracts from a hub, kit up with meaningful gear, and raid dangerous locations to hunt bounties — mutants and hostile humans — for cash, loot, and progression. Slow, tactical, lethal. Every raid is tense and hard-won. Extract with your loot and the proof of your kill, sell and repair at the hub, earn rep, unlock better gear and rare special-order weapons, and go back in stronger.



The feel: deliberate, immersive, grim-but-beautiful. Atmosphere and tension emerge from honest systems, not scripted events. A living hub, a radio playing, your gear laid out — then out into the Zone.



\*\*Core fantasy:\*\* the authentic, hardcore extraction-sim the Tarkov / STALKER / Arma i want — built with real firearms, ballistics, and medical knowledge, so the depth is genuine, not faked.



\---



\## Core Loop



1\. \*\*Hub\*\* — accept a contract/bounty at the board. Read it carefully (it tells you the mission: target, location, conditions).

2\. \*\*Prep / Kit Up\*\* — build a meaningful loadout for the raid (weapon, gear, mags, meds). Repair/maintain gear. Manage inventory.

3\. \*\*Raid\*\* — deploy to a location. Slow, tactical, lethal. Fight mutants and hostile humans. Loot the environment and dens. Hunt the bounty target.

4\. \*\*The Kill\*\* — take down the main target. Harvest the proof-of-kill (head/claw/hide — the item that proves it to traders).

5\. \*\*Extract\*\* — survive and leave the location with your loot and proof.

6\. \*\*Return to Hub\*\* — sell loot, turn in the bounty for cash, repair/replace gear, buy ammo/kits/parts. Build rep with traders.

7\. \*\*Progress\*\* — rep unlocks special-order weapons (rare, expensive, slow to arrive). Better gear = harder raids = bigger bounties.

8\. \*\*Repeat\*\* — back to the board, stronger, for the next contract.



\*\*Single player. Contained maps (a couple), not an open world.\*\*



\### Weapons \& Repair Tiers



\- \*\*No direct weapon sales.\*\* Guns are looted (often damaged) and built/repaired from stripped parts + tiered repair kits.

\- \*\*Repair kit tiers gate what you can fix:\*\*

&#x20; - \*\*Class A\*\* — handguns, some SMGs.

&#x20; - \*\*Class B\*\* — older weapons: bolt actions, SKS, that era.

&#x20; - \*\*Class C\*\* — assault rifles, battle rifles.

\- Weapon condition matters (ties into ballistics/degradation — worn weapons perform worse).

\- Vendors sell \*\*parts, repair kits, ammo\*\* — not guns.



\### Special Orders



\- High rep unlocks \*\*special orders\*\* — rare imports, high cash, long wait times (e.g., an SR25 after \~10 in-game days).

\- A special order gets you the hard-to-find \*\*shell/frame\*\* (the roughly-complete weapon body) — NOT a finished working gun.

\- The full parts/repair progression still applies: you still source/build/repair the internals to get it running.

\- So special orders solve \*rarity/access\* (the hard-to-find frame), not the \*build grind\* — the weapon-building system stays meaningful even for rare guns.




\---



\## Pillars / Feel



\- \*\*Sim-cade, not full-sim.\*\* Systems feel realistic and deep, but stay playable — not exhaustively simulated. Realistic enough to matter, simple enough to be fun.

\- \*\*Systems produce the vibe.\*\* Atmosphere and tension emerge from honest systems, not scripted events. A living hub, emergent dread, the feeling of the Zone — all outputs of the systems.

\- \*\*Honest systems collide via truth.\*\* Model each system honestly (real ballistics, real anatomy, real gear) and the interactions emerge for free — height-over-bore, organ-specific damage, etc. Low effort on the collisions, high effort on the depth of each system.

\- \*\*Knowledge is progression.\*\* The player gets stronger by \*learning the world\*, not just by stats. You learn where a mutant's organs are, how its behavior works — and that knowledge is your power.

\- \*\*Player-authored.\*\* The game doesn't hand you a wiki. You keep a notebook, draw the mutants, mark their organs, write your own notes as you hunt and harvest. Your knowledge is earned and yours.

\- \*\*Grim, atmospheric, deliberate.\*\* Post-Soviet / post-apocalyptic. Slow, tactical, lethal. Beauty in decay. The music and mood carry as much as the mechanics.

\- \*\*Authentic.\*\* Real firearms, ballistics, and medical knowledge drive the depth — made by someone who lives this, so it rings true.




\---



\## Systems



Each system notes its scope and rough build status. "Core" = needed for the core prototype. "Later" = deepened/added in refine cycles.



\### Ballistics (sim-cade)

\- Physical projectiles with real-ish flight. Fast, feel like bullets.

\- Damage driven by energy — ft-lbs calculated from round weight + velocity (velocity affected by barrel length, round type).

\- Raycast-the-path hit detection (bullet flies real, hits detected via short ray — reliable at high speed, no tunneling).

\- Bullet owns its own flight (gun launches it, bullet flies itself via its \_moveDir).

\- \*\*Core:\*\* straight-flight projectile + raycast hit + flat damage. \*(done)\*

\- \*\*Later:\*\* bullet drop (gravity arc), velocity loss over time, camera-aim convergence, penetration (pass-through, reassign \_moveDir), ricochet (reflect off surface normal), zeroing, manual zeroing range, barrel-degradation — loss of accuracy (maybe thousands of rounds to do so).



\### Health / Medical (sim-cade)

\- \*\*Core:\*\* simple HP — take damage, die, fire OnDeath event. \*(done)\*

\- \*\*Later:\*\* organs over HP (hit-location damage — organs in unexpected places per mutant), simple armor (penetrate vs stop), medical system (engaging, simple sim-cade — ties to the medic background).



\### Enemies / AI

\- Mutants and hostile humans.

\- \*\*Core:\*\* simple chase (move toward player). \*(done, placeholder)\*

\- \*\*Later:\*\* perception-based awareness — enemies don't know the player exists until made aware via sight / sound / smell. Awareness states (unaware → suspicious → alerted). No omniscience.




\### Inventory

\- \*\*Core prototype:\*\* STALKER/GAMMA-style backpack — clean list/window, items auto-grouped by category on loot (ammo together, meds together, etc.), stacked with counts, favorites (ammo/repair kits/meds) prioritized/accessible. Data-driven organization (not spatial-grid).

\- \*\*Later cycle:\*\* Tarkov-style grid for the chest rig / plate carrier — spatial, quick-access combat gear (mags, meds) you grab without opening the bag. Purpose-driven dual-inventory: clean-list backpack (storage/overview) + grid rig (fast combat kit).

\- Equipped gear slots (weapon, armor, vision, backpack, rig) — character equipment.



\### Loot

\- Data-driven: items have category, stack info, value, etc.

\- Sources: world loot / crates, and creature dens (bone-pile hoards — atmospherically "remains of past victims"), and mutants you can skin them for parts.

\- Weighted loot tables (remade from console loot system — template/pool/weighted-drop).

\- Sources: world loot / crates, and creature dens.

\- \*\*Den loot = victim remains (atmospheric framing).\*\* Dens hold loot indicative of those who came before and died — a trashed rig, loose mags, ammo, an attachment, meds. Tells the world's story through loot, no dialogue. This is themed/static (a loot table that reads like scavenged-victim-gear) — NOT dynamic tracking of the player's own lost gear.

\- \*\*Core:\*\* enemy/container drops an item → pick it up → inventory.

\- \*\*Later:\*\* richer/varied loot tables, deeper den-hoard theming.



\### Weapons \& Economy

\- See Core Loop → Weapons \& Repair Tiers + Special Orders for the full weapon-acquisition design.

\- Summary: \*\*no gun sales\*\* — guns found/built from parts (GAMMA-style) + tiered repair kits (A/B/C). Special orders = rare shell, parts-progression still applies.

\- Vendors sell parts, repair kits, ammo. Trader rep unlocks special orders.

\- Weapon modifications: typed arrays (attachments as data — rails, optics, etc.).

\- \*\*Core:\*\* simple — a found weapon that works (deep repair/parts economy is later).

\- \*\*Later:\*\* full parts/repair/tier economy, weapon mods, special-order system.


\### Extraction / Persistence

\- Extraction = leave the raid (scene transition) back to a safe area/hub.

\- \*\*Persist across extraction (survive the scene change):\*\* player, inventory, loot gained, InputManager. (Later: missions/bounty, rep, hub state.)

\- \*\*Reset (die with the raid scene):\*\* enemies, un-looted ground loot, raid environment, spawners, raid state.

\- \*\*Core:\*\* raid scene ↔ safe scene transition that respects persist-vs-reset. (Foundational — establish early so everything is built within it.)

\- Known hard area (scene persistence bit me last project) — tackle the skeleton early, reps reinforce it.



\### Hub / Traders / Missions / Rep

\- Hub (in-game or scene-based — TBD) with traders, mission/bounty board, rep, small hideout.

\- Traders: sell loot, buy ammo/parts/kits, turn in bounties. Rep builds over time → unlocks special orders.

\- Missions/bounties: accept a contract (target, location, conditions), hunt it, bring back proof-of-kill.

\- \*\*Core:\*\* simple version — a basic hub/screen to sell loot + gear up between raids.

\- \*\*Later:\*\* full traders, rep system, mission board, special orders, hideout.



\### Mutant Notebook (standout feature)

\- Starts empty. As you kill/harvest mutants, you \*choose\* to log them.

\- Logging adds an outline of the mutant you can annotate — draw organ locations (which are in unexpected places, differ per mutant), mark points of aim, write notes based on your harvest.

\- You reference your notebook in-field. Knowledge IS progression — knowing where the heart/lungs/brain are = hitting them = better combat.

\- Forget to log a kill → fly blind next time you face that mutant.

\- Player-authored (you make the notes, not a handed wiki). Deeply ties to the organ/hit-location damage system.

\- \*\*Later feature\*\* (needs organs/hit-location + mutants + notebook UI first) — but a defining, standout mechanic.

## Scope 

good to 

\*\*In (the real game, built incrementally):\*\*

Core extraction loop (raid → fight → loot → extract → hub → gear → repeat), sim-cade ballistics, sim-cade health/medical, inventory, weapon find-and-repair economy, loot, enemies (mutants + humans), hub/traders/missions/rep, a couple maps.

\*\*Build philosophy:\*\* core prototype first (placeholder everything) → refine to super-alpha → deepen. One system at a time. Cut/add as reality informs. Made one day at a time, for as long as it takes.



\---



\## Banked Later-Features (dream-tier / way-later)



Captured so they're not lost — explicitly NOT for now. Build toward them only if/when the core earns it.



\- \*\*Manual zeroing range\*\* — walk your optic into zero with turret clicks at a range; zero affects point-of-impact at distance (real ballistics emerge from honest drop + adjustable sight).

\- \*\*Deep ballistics\*\* — penetration (pass-through + path change), ricochet, barrel-degradation accuracy loss over thousands of rounds.

\- \*\*Mutant notebook\*\* (see Systems) — the full player-authored organ-knowledge notebook.

\- \*\*Organs over HP\*\* — hit-location damage, organs in unexpected places per mutant, feeds the notebook.

\- \*\*Perception-based AI\*\* — sight/sound/smell awareness, awareness states, no omniscience.

\- \*\*Tarkov-style grid rig\*\* — the spatial combat-kit inventory (after the GAMMA bag).



\*\*Note:\*\* these are the vision's depth. The game is real and good WITHOUT most of them — they're what it grows into if it proves worth growing.



