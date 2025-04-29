import axios from "axios";
import { api } from "../API.service";
import { handleError } from "../../helpers/error-handler.helper";
import { UserClientModel } from "../../models/user-client.model";

export const GetAllSuppliers = async () => {
  try {
    const data = await axios.get<UserClientModel[]>(
      api + "get-all-suppliers/?id=3"
    );
    return data;
  } catch (err) {
    handleError(err);
  }
};
