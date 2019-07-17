# Blazor.ModelManager
A System for presenting Business model trees in Blazor with minimal Boiler plate

A WIP system that will allow implementers to present business models with blazor with no required boiler plate

When finished aims to have the following features

Implmenters will
- Define POCO business model
- Define manager for a given model type that is kept up to date with current interested keys for the model type from any component attmepting to render
- Define Razor view extending ModelComponent<ModelType> and update the component with the interested key

The system will keep managers up to date with interested keys and automatically update the model in the ModelComponent class with the latest model

Existing managers and models will be defined to render common data structures like trees and lists in the future.