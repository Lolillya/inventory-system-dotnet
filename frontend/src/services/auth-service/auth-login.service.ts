import { handleError } from "../../helpers/error-handler.helper";
import { UserProfileToken } from "../../models/user.model";
import axios from "axios";

const api = "http://localhost:5055/api/";

export const loginAPI = async (username: string, password: string) => {
  try {
    const data = await axios.post<UserProfileToken>(api + "auth/login/", {
      username: username,
      password: password,
    });
    return data;
  } catch (error) {
    handleError(error);
  }
};
