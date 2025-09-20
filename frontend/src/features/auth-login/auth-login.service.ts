import { handleError } from "../../helpers/error-handler.helper";
import { UserProfileToken } from "../../models/user.model";
import { api } from "../api/API.service";
import axios from "axios";

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
