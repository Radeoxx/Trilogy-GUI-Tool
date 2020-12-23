// Copyright (c) 2019 Lordmau5
using GtaChaos.Models.Effects.@abstract;
using GtaChaos.Models.Effects.extra;
using GtaChaos.Models.Effects.impl;
using GtaChaos.Models.Utils;
using System;
using System.Collections.Generic;

namespace GtaChaos.Models.Effects
{
    public static class EffectDatabase
    {
        public static List<AbstractEffect> Effects { get; } = new List<AbstractEffect> { };

        public static void PopulateEffects(string game)
        {
            foreach (Category cat in Category.Categories)
            {
                cat.ClearEffects();
            }
            Effects.Clear();
            EnabledEffects.Clear();

            if (game == "san_andreas")
            {
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Set de armas 1", "ThugsArmoury", "weapon_set_1")); // Weapon Set 1
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Set de armas 2", "ProfessionalsKit", "weapon_set_2")); // Weapon Set 2
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Set de armas 3", "NuttersToys", "weapon_set_3")); // Weapon Set 3
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Set de armas 4", "MinigunMadness", "weapon_set_4")); // Weapon Set 4
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Salud, Armadura, +$250k", "INeedSomeHelp", "health_armor_money")); // Health, Armor, $250k
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Suicidio", "GoodbyeCruelWorld", "suicide").SetAudioFile("roblox_oof").DisableRapidFire()); // Suicide
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Municion Infinita", "FullClip", "infinite_ammo")); // Infinite ammo
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Salud Infinita (Jugador)", "NoOneCanHurtMe", "infinite_health")); // Infinite Health (Player)

                Effects.Add(new FunctionEffect(Category.WantedLevel, "\"Se busca\" +2 Estrellas", "TurnUpTheHeat", "wanted_plus_two")); // Wanted level +2 stars
                Effects.Add(new FunctionEffect(Category.WantedLevel, "Quitar nivel de \"Se busca\"", "TurnDownTheHeat", "clear_wanted")); // Clear wanted level
                Effects.Add(new FunctionEffect(Category.WantedLevel, "No \"Se busca\"", "IDoAsIPlease", "never_wanted")); // Never wanted
                Effects.Add(new FunctionEffect(Category.WantedLevel, "6 estrellas \"Se busca\"", "BringItOn", "wanted_six_stars").DisableRapidFire()); // Six wanted stars

                Effects.Add(new WeatherEffect("Clima Soleado", "PleasantlyWarm", 1)); // Sunny weather
                Effects.Add(new WeatherEffect("Clima Muy Soleado", "TooDamnHot", 0)); // Very sunny weather
                Effects.Add(new WeatherEffect("Clima Nublado", "DullDullDay", 4)); // Overcast weather
                Effects.Add(new WeatherEffect("Clima Lluvioso", "StayInAndWatchTV", 16)); // Rainy weather
                Effects.Add(new WeatherEffect("Niebla", "CantSeeWhereImGoing", 9)); // Foggy weather
                Effects.Add(new WeatherEffect("Clima Tormentoso", "ScottishSummer", 16)); // Thunder storm
                Effects.Add(new WeatherEffect("Tormenta De Arena", "SandInMyEars", 19)); // Sand storm

                Effects.Add(new FunctionEffect(Category.Spawning, "Dar Paracaidas", "LetsGoBaseJumping", "get_parachute")); // Get Parachute
                Effects.Add(new FunctionEffect(Category.Spawning, "Dar Jetpack", "Rocketman", "get_jetpack")); // Get Jetpack
                Effects.Add(new SpawnVehicleEffect("TimeToKickAss", 432)); // Spawn Rhino
                Effects.Add(new SpawnVehicleEffect("OldSpeedDemon", 504)); // Spawn Bloodring Banger
                Effects.Add(new SpawnVehicleEffect("DoughnutHandicap", 489)); // Spawn Rancher
                Effects.Add(new SpawnVehicleEffect("NotForPublicRoads", 502)); // Spawn Hotring A
                Effects.Add(new SpawnVehicleEffect("JustTryAndStopMe", 503)); // Spawn Hotring B
                Effects.Add(new SpawnVehicleEffect("WheresTheFuneral", 442)); // Spawn Romero
                Effects.Add(new SpawnVehicleEffect("CelebrityStatus", 409)); // Spawn Stretch
                Effects.Add(new SpawnVehicleEffect("TrueGrime", 408)); // Spawn Trashmaster
                Effects.Add(new SpawnVehicleEffect("18Holes", 457)); // Spawn Caddy
                Effects.Add(new SpawnVehicleEffect("JumpJet", 520)); // Spawn Hydra
                Effects.Add(new SpawnVehicleEffect("IWantToHover", 539)); // Spawn Vortex
                Effects.Add(new SpawnVehicleEffect("OhDude", 425)); // Spawn Hunter
                Effects.Add(new SpawnVehicleEffect("FourWheelFun", 471)); // Spawn Quad
                Effects.Add(new SpawnVehicleEffect("ItsAllBull", 486)); // Spawn Dozer
                Effects.Add(new SpawnVehicleEffect("FlyingToStunt", 513)); // Spawn Stunt Plane
                Effects.Add(new SpawnVehicleEffect("MonsterMash", 556)); // Spawn Monster
                Effects.Add(new SpawnVehicleEffect("SurpriseDriver", -1)); // Spawn Random Vehicle

                Effects.Add(new FunctionEffect(Category.Time, "Velocidad de tiempo x0.25", "MatrixMode", "quarter_gamespeed", -1, 1.0f / 3.0f)); // Quarter Gamespeed
                Effects.Add(new FunctionEffect(Category.Time, "Velocidad de tiempo x0.5", "SlowItDown", "half_gamespeed", -1, 2.0f / 3.0f)); // Half Gamespeed
                Effects.Add(new FunctionEffect(Category.Time, "Velocidad de tiempo x2", "SpeedItUp", "double_gamespeed")); // Double Gamespeed
                Effects.Add(new FunctionEffect(Category.Time, "Velocidad de tiempo x4", "YoureTooSlow", "quadruple_gamespeed")); // Quadruple Gamespeed
                Effects.Add(new FunctionEffect(Category.Time, "Siempre Medianoche", "NightProwler", "always_midnight")); // Always midnight
                Effects.Add(new FunctionEffect(Category.Time, "Parar Reloj De Juego", "DontBringOnTheNight", "stop_game_clock")); // Stop game clock, orange sky
                Effects.Add(new FunctionEffect(Category.Time, "Reloj Mas Rapido", "TimeJustFliesBy", "faster_clock")); // Faster clock

                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Estallar Coches Cercanos", "AllCarsGoBoom", "blow_up_all_cars").DisableRapidFire()); // Blow up all cars
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Trafico Rosa", "PinkIsTheNewCool", "pink_traffic")); // Pink traffic
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Trafico Negro", "SoLongAsItsBlack", "black_traffic")); // Black traffic
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Coches Baratos", "EveryoneIsPoor", "cheap_cars")); // Cheap cars
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Coches Caros", "EveryoneIsRich", "expensive_cars")); // Expensive cars
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Demente Al Volante", "StickLikeGlue", "insane_handling")); // Insane handling
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Semaforos En Verde", "DontTryAndStopMe", "all_green_lights")); // All green lights
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Los Coches Flotan En El Agua", "JesusTakeTheWheel", "cars_on_water")); // Cars on water
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Barcos Voladores", "FlyingFish", "boats_fly")); // Boats fly
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Coches Voladores", "ChittyChittyBangBang", "cars_fly")); // Cars fly
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Choca Y Estalla", "TouchMyCarYouDie", "smash_n_boom")); // Smash n' boom
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Todos Los Coches Llevan Nitro", "SpeedFreak", "all_cars_have_nitro")); // All cars have nitro
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Todos Los Coches Flotan Al Chocar", "BubbleCars", "cars_float_away_when_hit")); // Cars float away when hit
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Todos Los Taxis Llevan Nitro", "SpeedyTaxis", "all_taxis_have_nitro")); // All taxis have nitrous
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Vehiculos Invisibles (Solo Ruedas)", "WheelsOnlyPlease", "wheels_only_please")); // Invisible Vehicles (Only Wheels)

                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Las Personas Se Pegan Entre Ellos", "RoughNeighbourhood", "peds_attack_each_other")); // Peds attack other (+ get golf club)
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Recompensa Por Tu Cabeza", "StopPickingOnMe", "have_a_bounty_on_your_head")); // Have a bounty on your head
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "ELvis Esta Por Todos Lados", "BlueSuedeShoes", "elvis_is_everywhere")); // Elvis is everywhere
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Las Personas Te Atacan", "AttackOfTheVillagePeople", "peds_attack_you")); // Peds attack you
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Miembros De Banda Por Todos Lados", "OnlyHomiesAllowed", "gang_members_everywhere")); // Gang members everywhere
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Las Bandas Controlan Las Calles", "BetterStayIndoors", "gangs_control_the_streets")); // Gangs control the streets
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Modo Disturbios", "StateOfEmergency", "riot_mode")); // Riot mode
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Todo El Mundo Armado", "SurroundedByNutters", "everyone_armed")); // Everyone armed
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Conductores Agresivos", "AllDriversAreCriminals", "aggressive_drivers")); // Aggressive drivers
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Reclutar A Cualquiera (9mm)", "WannaBeInMyGang", "recruit_anyone_9mm")); // Recruit anyone (9mm)
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Reclutar A Cualquiera (AK-47)", "NoOneCanStopUs", "recruit_anyone_ak47")); // Recruit anyone (AK-47)
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Reclutar A Cualquiera (Cohetes)", "RocketMayhem", "recruit_anyone_rockets")); // Recruit anyone (Rockets)
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Ciudad Fantasma", "GhostTown", "ghost_town")); // Reduced traffic
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Fiesta En La Playa", "LifesABeach", "beach_theme")); // Beach party
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Tematica Ninja", "NinjaTown", "ninja_theme")); // Ninja theme
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Tematica Kinky", "LoveConquersAll", "kinky_theme")); // Kinky theme
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Tematica Casa De La Diversion", "CrazyTown", "funhouse_theme")); // Funhouse theme
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Tematica Country", "HicksVille", "country_traffic")); // Country traffic

                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Apunta Mientras Conduces", "IWannaDriveBy", "weapon_aiming_while_driving")); // Weapon aiming while driving
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Bunny Hop Gigantesco", "CJPhoneHome", "huge_bunny_hop")); // Huge bunny hop
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Mega Salto", "Kangaroo", "mega_jump")); // Mega jump
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Oxigeno Infinito", "ManFromAtlantis", "infinite_oxygen")); // Infinite oxygen
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Mega Cuerpo A Cuerpo", "StingLikeABee", "mega_punch")); // Mega punch

                Effects.Add(new FunctionEffect(Category.Stats, "CJ Gordo", "WhoAteAllThePies", "fat_player")); // Fat player
                Effects.Add(new FunctionEffect(Category.Stats, "Musculo Al Maximo", "BuffMeUp", "muscle_player")); // Max muscle
                Effects.Add(new FunctionEffect(Category.Stats, "CJ Flaco", "LeanAndMean", "skinny_player")); // Skinny player
                Effects.Add(new FunctionEffect(Category.Stats, "Aguante Al Tope", "ICanGoAllNight", "max_stamina")); // Max stamina
                Effects.Add(new FunctionEffect(Category.Stats, "Sin Aguante", "ImAllOutOfBreath", "no_stamina")); // No stamina
                Effects.Add(new FunctionEffect(Category.Stats, "Nivel Asesino Con Todas Las Armas", "ProfessionalKiller", "hitman_level_for_all_weapons")); // Hitman level for all weapons
                Effects.Add(new FunctionEffect(Category.Stats, "Nivel Principiante Con Todas Las Armas", "BabysFirstGun", "beginner_level_for_all_weapons")); // Beginner level for all weapons
                Effects.Add(new FunctionEffect(Category.Stats, "Nivel De Conduccion Al Maximo", "NaturalTalent", "max_driving_skills")); // Max driving skills
                Effects.Add(new FunctionEffect(Category.Stats, "Nivel De Conduccion Al Minimo", "BackToDrivingSchool", "no_driving_skills")); // No driving skills
                Effects.Add(new FunctionEffect(Category.Stats, "No Tienes Hambre", "IAmNeverHungry", "never_get_hungry")); // Never get hungry
                Effects.Add(new FunctionEffect(Category.Stats, "Bloquear Respeto Al Maximo", "WorshipMe", "lock_respect_at_max")); // Lock respect at max
                Effects.Add(new FunctionEffect(Category.Stats, "Bloquear Sex Appeal Al Maximo", "HelloLadies", "lock_sex_appeal_at_max")); // Lock sex appeal at max

                Effects.Add(new FunctionEffect(Category.CustomEffects, "Quitar Efectos Activos", "ClearActiveEffects", "clear_active_effects").SetType("other").DisableTwitch()); // Clear Active Effects
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Quitar Todas Las Armas", "NoWeaponsAllowed", "remove_all_weapons")); // Remove all weapons
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Te Atrapa La Poli", "GoToJail", "get_busted").SetAudioFile("busted").DisableRapidFire()); // Get's you busted on the spot
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Muerte Subita", "Hospitality", "get_wasted").SetAudioFile("wasted").DisableRapidFire()); // Get's you wasted on the spot
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Prende Fuego A Todos", "HotPotato", "set_everyone_on_fire").DisableRapidFire()); // Set everyone on fire
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Saca Al Jugador Del Vehiculo", "ThisAintYourCar", "kick_player_out_of_vehicle")); // Kick player out of vehicle
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Encierra Al Jugador En El Vehiculo", "ThereIsNoEscape", "lock_player_inside_vehicle")); // Lock player inside vehicle
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Prende Fuego Al Vehiculo", "WayTooHot", "set_current_vehicle_on_fire").DisableRapidFire()); // Set current vehicle on fire
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pincha Las Ruedas De Todos Los Vehiculos", "TiresBeGone", "pop_tires_of_all_vehicles")); // Pop tires of all vehicles
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Envia Los Vehiculos Al Espacio", "StairwayToHeaven", "send_vehicles_to_space").SetAudioFile("show_you_the_world")); // Gives an immense upwards boost to all vehicles
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Dar La Vuelta A Todos Los Coches", "TurnAround", "turn_vehicles_around")); // Turn vehicles around
                Effects.Add(new FunctionEffect(Category.CustomEffects, "A La Derecha... A La Izquierda...", "ToTheLeftToTheRight", "to_the_left_to_the_right")); // Gives cars a random velocity
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Modo Tiempo Rapido", "DiscoInTheSky", "timelapse")); // Timelapse mode
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Donde Esta Todo El Mundo?", "ImHearingVoices", "where_is_everybody")); // Where is everybody?
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Todo El Mundo A Sangrar!", "EverybodyBleedNow", "everybody_bleed_now", -1, 0.5f)); // Everybody bleed now!
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Conducir O No Conducir", "ToDriveOrNotToDrive", "to_drive_or_not_to_drive")); // To drive or not to drive
                Effects.Add(new FunctionEffect(Category.CustomEffects, "1 HP", "ILikeToLiveDangerously", "one_hit_ko").DisableRapidFire()); // One Hit K.O.
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Experimenta El Lag", "PacketLoss", "experience_the_lag")); // Experience the lag
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Coche Ardiente", "GhostRider", "ghost_rider")); // Set current vehicle constantly on fire
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Desactivar Interfaz", "FullyImmersed", "disable_hud")); // Disable HUD
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Desactivar Puntos En El Mapa / Marcadores / Recogidas", "INeedSomeInstructions", "disable_blips_markers_pickups")); // Disable Blips / Markers / Pickups
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Armas De Fogueo", "TruePacifist", "disable_all_weapon_damage")); // Disable all Weapon Damage
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Vamo A Calmarno", "LetsTakeABreak", "lets_take_a_break").SetAudioFile("elevator_music").DisableRapidFire()); // Let's take a break
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Coches Del Orgullo", "AllColorsAreBeautiful", "pride_cars")); // Pride Cars
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Amortiguacion Suave", "VeryDampNoBounce", "high_suspension_damping")); // Cars have high suspension damping
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Amortiguacion Rigida", "LowrideAllNight", "zero_suspension_damping"));  // Cars have almost zero suspension damping
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Larga Vida Al Ricachon!", "LongLiveTheRich", "long_live_the_rich"));  // Money = Health, shoot people to gain money, take damage to lose it
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Controles Invertidos", "InvertedControls", "inverted_controls"));  // Inverts some controls
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Desactiva Un Boton De Movimiento", "DisableOneMovementKey", "disable_one_movement_key"));  // Disable one movement key
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Fallar Mision Actual", "MissionFailed", "fail_current_mission").DisableRapidFire()); // Fail Current Mission
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Vision Nocturna", "NightVision", "night_vision")); // Night Vision
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Vision Termica", "ThermalVision", "thermal_vision")); // Thermal Vision
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Completar Mision Actual", "IllTakeAFreePass", "pass_current_mission")); // Pass Current Mission
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Salud Infinitas (Todos)", "NoOneCanHurtAnyone", "infinite_health_everyone")); // Infinite Health (Everyone)
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Vehiculos Invisibles", "InvisibleVehicles", "invisible_vehicles")); // Invisible Vehicles
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Presentacion PowerPoint", "PowerpointPresentation", "framerate_15")); // Powerpoint Presentation (15 FPS)
                Effects.Add(new FunctionEffect(Category.CustomEffects, "60 FPS", "SmoothCriminal", "framerate_60")); // Smooth Criminal (60 FPS)
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Cargar Guardado Automatico", "HereWeGoAgain", "reload_autosave").SetAudioFile("here_we_go_again").DisableRapidFire()); // Reload Autosave
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Cuarto De Gravedad", "GroundControlToMajorTom", "quarter_gravity")); // Sets the gravity to 0.002f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Mitad De Gravedad", "ImFeelingLightheaded", "half_gravity")); // Sets the gravity to 0.004f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Gravedad Doble", "KilogramOfFeathers", "double_gravity")); // Sets the gravity to 0.016f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Gravedad Cuadruple", "KilogramOfSteel", "quadruple_gravity")); // Sets the gravity to 0.032f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Gravedad Invertida", "BeamMeUpScotty", "inverted_gravity").SetAudioFile("moon_theme").DisableRapidFire()); // Sets the gravity to -0.002f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Gravedad Cero", "ImInSpaaaaace", "zero_gravity").DisableRapidFire()); // Sets the gravity to 0f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Gravedad Insana", "StraightToHell", "insane_gravity").DisableRapidFire()); // Sets the gravity to 0.64f
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Vision De Tunel", "TunnelVision", "tunnel_vision", -1, 1.0f / 3.0f).DisableRapidFire()); // Tunnel Vision
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Sonido De Tono Alto", "CJAndTheChipmunks", "high_pitched_audio")); // High Pitched Audio
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Cambiador De Tono", "VocalRange", "pitch_shifter")); // Pitch Shifter
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Completar Mision Actual", "IWontTakeAFreePass", "fake_pass_current_mission").DisableRapidFire()); // Fake Pass Current Mission
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Salvapantallas DVD", "ItsGonnaHitTheCorner", "dvd_screensaver", -1, 1.0f / 3.0f).DisableRapidFire()); // DVD Screensaver
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Turbo-Claxon", "GottaHonkFast", "honk_boost")); // Honk Boost
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Tanques!", "OhHeyTanks", "oh_hey_tanks").SetAudioFile("oh_hey_tanks")); // Spawns tanks around the player
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Siempre \"Se busca\"", "ICanSeeStars", "always_wanted").DisableRapidFire()); // Always Wanted
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Camara Cinematica En Vehiculos", "MachinimaMode", "cinematic_vehicle_camera")); // Cinematic Vehicle Camera
                //Effects.Add(new FunctionEffect(Category.CustomEffects, "Top Down Camera", "ReturnToTheClassics", "top_down_camera")); // Top Down Camera - BROKEN - CAN FLICKER AND SOFTLOCK
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Tu Coche Flota Al Chocar", "ImTheBubbleCar", "your_car_floats_away_when_hit")); // Your Car Floats Away When Hit
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Ring Ring !!", "RingRing", "ring_ring").SetAudioFile("banana_phone")); // Ring Ring !!
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Personas Explotan Al Ser Atropelladas", "ExplosivePeds", "peds_explode_when_run_over")); // Peds Explode When Run Over
                Effects.Add(new FunctionEffect(Category.CustomEffects, "PIIIIII!!!", "HONKHONK", "honk_vehicle").SetAudioFile("honk", 5)); // Honk Vehicle
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Campo De Vision De Quake", "QuakeFOV", "quake_fov").SetAudioFile("welcome_to_quake")); // Quake FOV
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Beyblade", "LetItRip", "beyblade").SetAudioFile("beyblade")); // Beyblade
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Ruleta De Armas", "WeaponRoulette", "weapon_roulette")); // Weapon Roulette
                Effects.Add(new FunctionEffect(Category.CustomEffects, "No Hay Prisa", "NoNeedToHurry", "no_need_to_hurry")); // No Need To Hurry
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Borrachera", "DrunkPlayer", "drunk_player")); // Drunk Player
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Control De Vehiculos Con El Raton", "ForceVehicleMouseSteering", "force_vehicle_mouse_steering")); // Force Vehicle Mouse Steering
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pantalla Boca-Abajo", "WhatsUpIsDown", "upside_down_screen", -1, 1.0f / 3.0f).SetAudioFile("down_under")); // Upside-Down Screen
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pantalla Reflejada", "WhatsLeftIsRight", "mirrored_screen", -1, 1.0f / 3.0f)); // Mirrored Screen
                //Effects.Add(new FunctionEffect(Category.CustomEffects, "Greyscale Screen", "GreyscaleScreen", "greyscale_screen", -1, 1.0f / 3.0f)); // Greyscale Screen
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Mundo Reflejado", "LetsTalkAboutParallelUniverses", "mirrored_world")); // Mirrored World
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Cabezones", "BigHeadsMode", "big_heads")); // Big Heads
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pedal Hasta El Metal", "PedalToTheMetal", "pedal_to_the_metal")); // Pedal To The Metal
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Los Vehiculos No Vuelcan", "ThereGoesMyBurrito", "unflippable_vehicles")); // Vehicles are unflippable
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Caida Libre!", "WhereWeDroppingBoys", "freefall")); // Freefall! - Gives CJ a parachute and teleports him very high
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Carromageddon", "Carmageddon", "carmageddon")); // Carmageddon - Makes vehicles rain from the sky!
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Usain Bolt", "FastestManAlive", "usain_bolt")); // Usain Bolt - Let's you run at incredibly high speeds!
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pasar Creditos", "WaitItsOver", "roll_credits")); // Roll Credits - Rolls the credits but only visually!
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Hambriento", "IllHave2Number9s", "instantly_hungry")); // Instantly Hungry - Makes CJ instantly hungry
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Camara De Parachoques En Vehiculos", "FrontRowSeat", "vehicle_bumper_camera")); // Vehicle Bumper Camera - Forces the vehicle's bumper camera

                // All teleports are disabled during Rapid-Fire mode
                Effects.Add(new TeleportationEffect("Bienvenido A Casa", "BringMeHome", Location.GrooveStreet));
                Effects.Add(new TeleportationEffect("Teletransporte A Una Torre", "BringMeToATower", Location.LSTower));
                Effects.Add(new TeleportationEffect("Teletransporte A Un Puerto", "BringMeToAPier", Location.LSPier));
                Effects.Add(new TeleportationEffect("Teletransporte Al Aeropuerto De Los Santos", "BringMeToTheLSAirport", Location.LSAirport));
                Effects.Add(new TeleportationEffect("Teletransporte A Los Muelles", "BringMeToTheDocks", Location.LSDocks));
                Effects.Add(new TeleportationEffect("Teletransporte Al Monte Chiliad", "BringMeToAMountain", Location.MountChiliad));
                Effects.Add(new TeleportationEffect("Teletransporte Al Aeropuerto De San Fierro", "BringMeToTheSFAirport", Location.SFAirport));
                Effects.Add(new TeleportationEffect("Teletransporte A Un Puente", "BringMeToABridge", Location.SFBridge));
                Effects.Add(new TeleportationEffect("Teletransporte A Un Lugar Secreto", "BringMeToASecretPlace", Location.Area52));
                Effects.Add(new TeleportationEffect("Teletransporte A Una Mina", "BringMeToAQuarry", Location.LVQuarry));
                Effects.Add(new TeleportationEffect("Teletransporte Al Aeropuerto De Las Venturas", "BringMeToTheLVAirport", Location.LVAirport));
                Effects.Add(new TeleportationEffect("Teletransporte A La Gran Oreja", "BringMeToBigEar", Location.LVSatellite));
                Effects.Add(new FunctionEffect(Category.Teleportation, "Teletransporte Aleatorio", "LetsGoSightseeing", "random_teleport")); // Random Teleport - Teleports CJ to a random location on the map
            }
            else if (game == "vice_city")
            {
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Weapon Set 1", "ThugsTools", "weapon_set_1"));
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Weapon Set 2", "ProfessionalTools", "weapon_set_2"));
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Weapon Set 3", "NutterTools", "weapon_set_3"));
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Full Health", "Aspirine", "full_health"));
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Full Armor", "PreciousProtection", "full_armor"));
                Effects.Add(new FunctionEffect(Category.WeaponsAndHealth, "Suicide", "ICantTakeItAnymore", "suicide"));

                Effects.Add(new FunctionEffect(Category.WantedLevel, "Clear Wanted Level", "LeaveMeAlone", "clear_wanted_level"));
                Effects.Add(new FunctionEffect(Category.WantedLevel, "Increase Wanted Level", "YouWontTakeMeAlive", "increase_wanted_level"));

                Effects.Add(new WeatherEffect("Cloudy Weather", "APleasantDay", 0));
                Effects.Add(new WeatherEffect("Very Cloudy Weather", "ABitDrieg", 1));
                Effects.Add(new WeatherEffect("Rainy Weather", "CatsAndDogs", 2));
                Effects.Add(new WeatherEffect("Foggy Weather", "CantSeeAThing", 3));
                Effects.Add(new WeatherEffect("Sunny Weather", "ALovelyDay", 4));

                Effects.Add(new SpawnVehicleEffect("RubbishCar", 138)); // Trashmaster
                Effects.Add(new SpawnVehicleEffect("Panzer", 162)); // Tank
                Effects.Add(new SpawnVehicleEffect("TheLastRide", 172)); // Hearse
                Effects.Add(new SpawnVehicleEffect("BetterThanWalking", 187)); // Caddie
                Effects.Add(new SpawnVehicleEffect("RockAndRollCar", 201)); // Limo
                Effects.Add(new SpawnVehicleEffect("GetThereFast", 206)); // Sabre Turbo
                Effects.Add(new SpawnVehicleEffect("GetThereVeryFastIndeed", 232)); // Hotring Racer
                Effects.Add(new SpawnVehicleEffect("GetThereAmazinglyFast", 233)); // Alt. Hotring Racer
                Effects.Add(new SpawnVehicleEffect("TravelInStyle", 234)); // Bloodring Banger
                Effects.Add(new SpawnVehicleEffect("GetThereQuickly", 235)); // Alt. Bloodring Banger

                Effects.Add(new FunctionEffect(Category.Time, "0.25x Game Speed", "MatrixMode", "quarter_game_speed"));
                Effects.Add(new FunctionEffect(Category.Time, "0.5x Game Speed", "Booooooring", "half_game_speed"));
                Effects.Add(new FunctionEffect(Category.Time, "2x Game Speed", "OnSpeed", "double_game_speed"));
                Effects.Add(new FunctionEffect(Category.Time, "4x Game Speed", "YoureTooSlow", "quadruple_game_speed"));
                Effects.Add(new FunctionEffect(Category.Time, "Quick Clock", "LifeIsPassingMeBy", "quick_clock"));

                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Aggressive Drivers", "MiamiTraffic", "aggressive_drivers"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "All Green Lights", "GreenLight", "all_green_lights"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Big Wheels", "LoadsOfLittleThings", "big_wheels"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Black Cars", "IWantItPaintedBlack", "black_cars"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Cars On Water", "Seaways", "cars_on_water"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Explode All Vehicles", "BigBang", "explode_all_vehicles"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Flying Boats", "Airship", "flying_boats"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Flying Cars", "ComeFlyWithMe", "flying_cars"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Insane Handling", "GripIsEverything", "insane_handling"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Pink Cars", "AHairDressersCars", "pink_cars"));
                Effects.Add(new FunctionEffect(Category.VehiclesTraffic, "Wheels Only", "WheelsAreAllINeed", "wheels_only"));

                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Armed Female Pedestrians", "ChicksWithGuns", "armed_female_peds"));
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Armed Pedestrians", "OurGodGivenRightToBearArms", "armed_peds"));
                //Effects.Add(new FunctionEffect(Category.PedsAndCo, "Hostile Peds", "NobodyLikesMe", "hostile_peds"));
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Ladies' Man", "FannyMagnet", "ladies_man"));
                Effects.Add(new FunctionEffect(Category.PedsAndCo, "Peds Get In Your Car", "HopInGirl", "peds_get_in_your_car"));
                //Effects.Add(new FunctionEffect(Category.PedsAndCo, "Riot Mode", "FightFightFight", "riot"));

                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Candy Suxxx Skin", "IWantBigTits", "candy_suxxx_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Dick Skin", "WeLoveOurDick", "dick_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Fat Skin", "DeepFriedMarsBars", "fat_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Hilary Skin", "ILookLikeHilary", "hilary_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Jezz Skin", "RockAndRollMan", "jezz_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Ken Skin", "MySonIsALawyer", "ken_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Lance Skin", "LookLikeLance", "lance_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Mercedes Skin", "FoxyLittleThing", "mercedes_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Phil Skin", "OneArmedBandit", "phil_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Random Outfit", "StillLikeDressingUp", "random_outfit"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Ricardo Skin", "CheatsHaveBeenCracked", "ricardo_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Skinny Skin", "Programmer", "skinny_skin"));
                Effects.Add(new FunctionEffect(Category.PlayerModifications, "Sonny Skin", "IDontHaveTheMoneySonny", "sonny_skin"));

                // Custom Effects
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Disable HUD", "DisableHUD", "disable_hud"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Disable Radar Blips", "DisableRadarBlips", "disable_radar_blips"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "DVD Screensaver", "DVDScreensaver", "dvd_screensaver"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Tunnel Vision", "TunnelVision", "tunnel_vision"));

                Effects.Add(new FunctionEffect(Category.CustomEffects, "Disable All Weapon Damage", "DisableAllWeaponDamage", "disable_all_weapon_damage"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Everybody Bleed Now", "EverybodyBleedNow", "everybody_bleed_now"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Infinite Health (Everyone)", "InfiniteHealthEveryone", "infinite_health_everyone"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Long Live The Rich", "LongLiveTheRich", "long_live_the_rich"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "One Hit K.O.", "OneHitKO", "one_hit_ko"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Remove All Weapons", "RemoveAllWeapons", "remove_all_weapons"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Set All Peds On Fire", "SetAllPedsOnFire", "set_all_peds_on_fire"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Where Is Everybody", "WhereIsEverybody", "where_is_everybody"));

                Effects.Add(new FunctionEffect(Category.CustomEffects, "Experience The Lag", "ExperienceTheLag", "experience_the_lag"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "15 FPS", "15FPS", "fps_15"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "60 FPS", "60FPS", "fps_60"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Timelapse", "Timelapse", "timelapse"));

                Effects.Add(new FunctionEffect(Category.CustomEffects, "Reload Autosave", "ReloadAutosave", "reload_autosave"));

                //Effects.Add(new FunctionEffect(Category.CustomEffects, "Ghost Rider", "GhostRider", "ghost_rider"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "High Suspension Damping", "HighSuspensionDamping", "high_suspension_damping"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Invisible Vehicles", "InvisibleVehicles", "invisible_vehicles"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Lightspeed Braking", "LightspeedBraking", "lightspeed_braking"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Little Suspension Damping", "LittleSuspensionDamping", "little_suspension_damping"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Pop Tires Of All Vehicles", "PopTiresOfAllVehicles", "pop_tires_of_all_vehicles"));
                //Effects.Add(new FunctionEffect(Category.CustomEffects, "Rainbow Cars", "RainbowCars", "rainbow_cars"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Send Vehicles To Space", "SendVehiclesToSpace", "send_vehicles_to_space"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Set Current Vehicle On Fire", "SetCurrentVehicleOnFire", "set_current_vehicle_on_fire"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "To Drive Or Not To Drive", "ToDriveOrNotToDrive", "to_drive_or_not_to_drive"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "To The Left, To The Right", "ToTheLeftToTheRight", "to_the_left_to_the_right"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Turn Vehicles Around", "TurnVehiclesAround", "turn_vehicles_around"));
                Effects.Add(new FunctionEffect(Category.CustomEffects, "Zero Suspension Damping", "ZeroSuspensionDamping", "zero_suspension_damping"));
            }
        }

        public static List<AbstractEffect> EnabledEffects { get; } = new List<AbstractEffect>();

        public static AbstractEffect GetByID(string id, bool onlyEnabled = false)
        {
            return (onlyEnabled ? EnabledEffects : Effects).Find(e => e.Id == id);
        }

        public static AbstractEffect GetByWord(string word, bool onlyEnabled = false)
        {
            return (onlyEnabled ? EnabledEffects : Effects).Find(e => !string.IsNullOrEmpty(e.Word) && string.Equals(e.Word, word, StringComparison.OrdinalIgnoreCase));
        }

        public static AbstractEffect GetByDescription(string description, bool onlyEnabled = false)
        {
            return (onlyEnabled ? EnabledEffects : Effects).Find(e => string.Equals(description, e.GetDescription(), StringComparison.OrdinalIgnoreCase));
        }

        public static AbstractEffect GetRandomEffect(bool onlyEnabled = false)
        {
            List<AbstractEffect> effects = (onlyEnabled ? EnabledEffects : Effects);
            if (effects.Count == 0)
            {
                return null;
            }
            return effects[RandomHandler.Next(effects.Count)];
        }

        public static AbstractEffect RunEffect(string id, bool onlyEnabled = true)
        {
            return RunEffect(GetByID(id, onlyEnabled));
        }

        public static AbstractEffect RunEffect(AbstractEffect effect, int seed = -1, int duration = -1)
        {
            if (effect != null)
            {
                effect.RunEffect(seed, duration);
            }
            return effect;
        }

        public static void SetEffectEnabled(AbstractEffect effect, bool enabled)
        {
            if (effect != null)
            {
                if (!enabled && EnabledEffects.Contains(effect))
                {
                    EnabledEffects.Remove(effect);
                }
                else if (enabled && !EnabledEffects.Contains(effect))
                {
                    EnabledEffects.Add(effect);
                }
            }
        }
    }
}
