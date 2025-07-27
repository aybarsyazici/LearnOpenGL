cmake_minimum_required(VERSION 3.20)
project(OpenGLProject)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# --- GLAD Library ---
# Create a library target for GLAD from its source file.
add_library(glad STATIC external/glad/src/glad.c)
# Specify that the "glad" target itself needs its own include directory to compile.
# And specify that anyone linking to "glad" (our executable) also needs this include directory.
target_include_directories(glad PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/external/glad/include)


# --- GLFW Library ---
# Create an "IMPORTED" library target for the pre-compiled GLFW library.
# This is the modern way to handle pre-built binaries.
add_library(glfw STATIC IMPORTED)

# Now, use set_target_properties to fill out the contract
set_target_properties(glfw PROPERTIES
        # Property 1: Tell CMake the EXACT location of the pre-built library file.
        # We use ${CMAKE_CURRENT_SOURCE_DIR} to make the path relative to the project.
        IMPORTED_LOCATION "${CMAKE_CURRENT_SOURCE_DIR}/external/glfw/lib/libglfw3.a"

        # Property 2: Tell CMake that anyone who links to 'glfw' needs this include directory.
        INTERFACE_INCLUDE_DIRECTORIES "${CMAKE_CURRENT_SOURCE_DIR}/external/glfw/include"
)


# --- Main Executable ---
add_executable(OpenGLProject main.cpp
        shader/shader_s.h
        textures/stb_image.cpp)

# Add the project root directory to the include paths
target_include_directories(OpenGLProject PRIVATE ${CMAKE_CURRENT_SOURCE_DIR})

# --- Linking ---
# Link all the necessary libraries to our executable.
# By linking `glad` and `glfw` targets, CMake automatically handles their include directories for us.
# We also need to link the system's OpenGL library and other dependencies for GLFW on Windows.
target_link_libraries(OpenGLProject PRIVATE glad glfw opengl32 gdi32)