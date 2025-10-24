// app/client.tsx
import { hydrateRoot } from "react-dom/client";
import { StartClient } from "@tanstack/react-start";
import { createRouter } from "./router";
import { QueryClientProvider } from "@tanstack/react-query";
import { getQueryClient } from "./lib/query-client";

const router = createRouter();
const queryClient = getQueryClient();

hydrateRoot(
  document,
  <QueryClientProvider client={queryClient}>
    <StartClient router={router} />
  </QueryClientProvider>
);
