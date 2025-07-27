# 🚀 My OpenGL Learning Journey 🚀

<p align="center">
  <a href="https://learnopengl.com/">
    <img src="https://img.shields.io/badge/Tutorial-LearnOpenGL.com-brightgreen.svg" alt="LearnOpenGL.com">
  </a>
  <img src="https://img.shields.io/badge/Language-C++-blue.svg" alt="Language C++">
  <img src="https://img.shields.io/badge/Build-CMake-orange.svg" alt="Build CMake">
  <img src="https://img.shields.io/badge/License-MIT-green.svg" alt="License MIT">
</p>

This repository is my personal chronicle of learning modern graphics programming. I am following the incredible tutorials at [learnopengl.com](https://learnopengl.com/), and this repo serves as a collection of my code, notes, and progress for each chapter.

---

## 🎥 Current Progress 🎥

*(To display this, place your `awesomeface_anim.gif` file in the same root directory as this README.)*
<p align="center">
  <img src="awesomeface_anim.gif" alt="A demonstration of texture mixing controlled by keyboard input" width="600"/>
</p>

---

## ✨ Current Feature Set

This project currently implements the foundational concepts from the "Getting Started" section of the tutorials:

*   **Window & Context:** Creates a modern OpenGL 3.3 Core Profile window using GLFW.
*   **Function Loading:** All OpenGL functions are loaded at runtime using GLAD.
*   **Render Pipeline:** Renders a 2D quad using a Vertex Buffer Object (VBO), Element Buffer Object (EBO), and Vertex Array Object (VAO).
*   **Shader Abstraction:** A simple C++ `Shader` class (`shader_s.h`) that loads, compiles, and links GLSL shaders from files.
*   **Texturing:** Loads and applies two separate 2D textures to the object using the `stb_image` library.
*   **Interactive Uniforms:** Blends the two textures using a `mixValue` uniform in the fragment shader.

---

## 🛠️ Core Libraries

This project is built upon a few essential libraries, which are included in the `external/` directory:

*   [**GLFW**](https://www.glfw.org/): For creating windows, contexts, and handling user input.
*   [**GLAD**](https://glad.dav1d.de/): For loading pointers to modern OpenGL functions.
*   [**stb_image**](https://github.com/nothings/stb/blob/master/stb_image.h): A single-header library for loading image files as textures.

---

## 📂 Project Structure

The repository is organized to keep source code, shaders, and assets separate. As I progress, this structure will expand to accommodate new tutorials.

```
.
├── CMakeLists.txt         # The main CMake build script
├── main.cpp               # Main application entry point and render loop
├── README.md              # You are here!
│
├── external/              # Third-party libraries
│   ├── glad/
│   └── glfw/
│
├── shader/                # GLSL shaders and C++ shader class
│   ├── chapter-name.vs    # Vertex Shaders for different tutorials
│   ├── chapter-name.fs    # Fragment Shaders for different tutorials
│   └── shader_s.h         # C++ Shader helper class
│
└── textures/              # Image assets and image loader
    ├── awesomeface.png
    ├── container.jpg
    └── stb_image.h
```

---

## 🚀 Getting Started

To build and run this project, you will need a C++ compiler and [CMake](https://cmake.org/download/).

1.  **Clone the repository:**
    ```sh
    git clone <your-repo-url>
    cd OpenGLProject
    ```

2.  **Create a build directory:**
    ```sh
    mkdir build
    cd build
    ```

3.  **Configure the project with CMake:**
    ```sh
    cmake ..
    ```

4.  **Compile and build the executable:**
    ```sh
    cmake --build .
    ```

5.  **Run the application:**
    ```sh
    # On Windows (from the build directory)
    .\Debug\OpenGLProject.exe

    # On Linux / macOS (from the build directory)
    ./OpenGLProject
    ```
<br>
<details>
<summary><b>Pro Tip: Keeping your repository clean with .gitignore</b></summary>

To prevent build files and IDE-specific folders from being uploaded to your repository, create a file named `.gitignore` in your project's root directory and add the following:

```gitignore
# CMake build files
/build/
/cmake-build-*/

# IDE-specific files
/.idea/
*.iml

# Compiled output
*.exe
*.so
*.dll
*.a
*.lib

# Visual Studio files
.vs/
*.sln
*.vcxproj*
```
</details>

---

## ⌨️ Controls

*   **`Arrow Up`**: Increase the visibility of the "awesomeface" texture.
*   **`Arrow Down`**: Decrease the visibility of the "awesomeface" texture.
*   **`ESC`**: Close the application.

---

## 🗺️ Roadmap / Next Steps

This is my planned path forward, following the `learnopengl.com` curriculum:

- [x] **Getting Started**
    - [x] OpenGL
    - [x] Creating a window
    - [x] Hello Window
    - [x] Hello Triangle
    - [x] Shaders
    - [x] Textures
- [ ] **Transformations**
- [ ] **Coordinate Systems**
- [ ] **Camera**
- [ ] **Lighting**
- [ ] **Model Loading**
- [ ] *...and beyond!*

---

## 🙏 Acknowledgements

*   A huge thank you to **Joey de Vries** for creating the comprehensive and accessible tutorials at [learnopengl.com](https://learnopengl.com/) that make this journey possible.