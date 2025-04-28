import axios from "axios";
import { api } from "../API.service";
import { handleError } from "../../helpers/error-handler.helper";
import { SupplierModel } from "../../models/supplier.model";

export const GetAllSuppliers = async () => {
  try {
    const data = await axios.get<SupplierModel[]>(api + "get-all-suppliers");
    return data;
  } catch (err) {
    handleError(err);
  }
};
