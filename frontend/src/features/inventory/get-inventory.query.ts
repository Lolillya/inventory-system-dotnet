import { useQuery } from "@tanstack/react-query"
import { InventoryProductModel } from "../../models/inventory.model"
import { GetInventory } from "./get-inventory.service"

export const UseInventoryQuery = () => {
    return useQuery<InventoryProductModel[]>({
        queryKey: ["inventory"],
        queryFn: async () => {
            const response = await GetInventory();
            if (!response) throw new Error("Failded to fetch inventory");
            // MODIFY LATER ANY AS DATA TYPE
            return response.data as any; 
        },
        staleTime: 60* 1000,
    })
}