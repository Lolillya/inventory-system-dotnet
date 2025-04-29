import axios from "axios";
import { api } from "../API.service";
import { handleError } from "../../helpers/error-handler.helper";
import { SupplierModel } from "../../models/supplier.model";

export const GetAllCustomers = async () => {
  try {
    const data = await axios.get<SupplierModel[]>(
      api + "get-all-suppliers/?id=4"
    );
    return data;
  } catch (err) {
    handleError(err);
  }
};
