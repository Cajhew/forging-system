
VRChat Forging System

Unity Hierarchy (Recommended):

ForgeWorld
│
├ Systems
│   ├ ForgeGameManager
│   ├ ForgeStateMachine
│   ├ WeatherController
│   ├ WeatherCycle
│   ├ RecipeSystem
│   ├ TierSystem
│   └ AffixSystem
│
├ ForgeStation
│   ├ Furnace
│   │   ├ FurnaceController
│   │   ├ FurnaceTemperature
│   │   ├ FurnaceTrigger
│   │   └ TongsSpawner
│   │
│   ├ Anvil
│   │   ├ ForgeController
│   │   ├ BlendShapeController
│   │   └ ForgeSoundController
│   │
│   ├ ToolRack
│   │   └ HammerSpawner
│   │
│   └ ForgeUI
│       ├ ForgeUIController
│       └ HeatUI / ProgressUI / ResultUI
│
├ SpawnPoints
│   ├ TongsSpawnPoint
│   ├ MetalSpawnPoint
│   └ PlayerStationPoint
│
├ Environment
│   ├ DirectionalLight
│   ├ Skybox
│   └ WeatherParticles
│
└ SafetySystems
    ├ RespawnSystem
    └ ObjectSafetySystem


Prefab Structure:

Furnace_Prefab
 ├ Mesh
 ├ Collider
 ├ FurnaceController
 ├ FurnaceTemperature
 ├ FurnaceTrigger
 └ TongsSpawner

Anvil_Prefab
 ├ Mesh
 ├ Collider
 ├ ForgeController
 ├ BlendShapeController
 └ ForgeSoundController

Tongs_Prefab
 ├ Mesh
 ├ Collider
 ├ Rigidbody
 ├ VRC_Pickup
 └ TongsController

Metal_Prefab
 ├ Mesh
 ├ Collider
 ├ Rigidbody
 ├ MetalState
 └ MetalSimulation

Hammer_Prefab
 ├ Mesh
 ├ Collider
 ├ Rigidbody
 ├ VRC_Pickup
 └ HammerController
