// vite.config.ts
import { defineConfig } from "vite";
import react from "@vitejs/plugin-react-swc";
import tailwindcss from "@tailwindcss/vite";
import path from "path";
import tsConfigPaths from "vite-tsconfig-paths";
var vite_config_default = defineConfig({
  plugins: [
    react(),
    tailwindcss(),
    tsConfigPaths({ projects: ["./tsconfig.json"] })
  ],
  resolve: {
    alias: {
      "@": path.resolve(__dirname, "./src")
    }
  }
});
export {
  vite_config_default as default
};
