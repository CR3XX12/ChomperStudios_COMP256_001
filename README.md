# 👾 The Descent: Lurkers of the Colony

*The Descent* is a VR survival shooter developed in Unity where players face waves of AI-controlled zombie crawlers on the alien world of Planet Y. Designed as a tech-focused prototype, the game combines machine learning-driven enemy AI, immersive UI, and responsive VR gameplay.

---

## 🎮 Gameplay Features

### 🧠 Enemy AI & ML Behavior

- Zombie crawlers trained using Unity ML-Agents with PPO (Proximal Policy Optimization).
- AI improves over time — agents actively track and pursue the player.
- Exported `.onnx` model integrated into Unity for runtime behavior.
- Wave-based spawning logic creates escalating challenge.
<center><img width="314" alt="CrawlerPic" src="https://github.com/user-attachments/assets/7db53310-9bfe-4018-b03f-92e363cfefca"</center>

### 🔫 Player Combat & Mechanics

- Players blast crawlers using a VR blaster.
- Supports VR tracking and fallback keyboard/mouse input (via XR Device Simulator).
- Dual input systems for flexible testing and gameplay.
- Death triggers custom game over logic and scene.
![image](https://github.com/user-attachments/assets/ed7bb818-aaaa-4043-914b-28f99fee9053)



### 💀 Health & Game Over Logic

- Custom death sequence when health is depleted.
- Seamless scene transitions: game start → active play → game over.
- UI feedback for health status and end state.
![image](https://github.com/user-attachments/assets/d77989b5-4f99-4d25-b99d-90f06394c63c)


### 🧩 UI/UX Design

- VR-following UI for player immersion.
- Scalable, headset-friendly layout for comfort and clarity.
- Custom menus, intro screen, logo, and death screen included.

### 🔬 AI Training Details

- **Algorithm:** PPO (Proximal Policy Optimization)  
- **Environment:** Unity ML-Agents Toolkit  
- **Training Duration:** ~3400 seconds for 10 million steps  
- **Final Cumulative Reward:** ~2,895  
- **Exported Model:** `Crawler-10000008.onnx`  
- Training graphs showed steady improvement and reward stability.
![image](https://github.com/user-attachments/assets/3a14ef82-94b1-4971-bdae-efabfe3ec1fb)

---

## 🛠️ Built With

- Unity + XR Toolkit
- Unity ML-Agents (Machine Learning)
- ONNX model integration for trained AI
- Custom VR UI/UX
- XR Device Simulator for non-VR testing

---
