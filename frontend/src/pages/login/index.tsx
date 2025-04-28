import { useAuth } from "../../context/use-auth";
import { useForm } from "react-hook-form";
import Logo from "/Company_Logo.svg";
import * as Yup from "yup";
import { yupResolver } from "@hookform/resolvers/yup";

type LoginFormInputs = {
  userName: string;
  password: string;
};

const validation = Yup.object().shape({
  userName: Yup.string().required("Username is required"),
  password: Yup.string().required("Password is required"),
});

const LoginPage = () => {
  const { loginUser } = useAuth();
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<LoginFormInputs>({ resolver: yupResolver(validation) });

  const handleLogin = (form: LoginFormInputs) => {
    loginUser(form.userName, form.password);
  };

  return (
    <section className="min-h-screen flex items-center justify-center">
      <div className="container max-w-md mx-auto p-6 space-y-8">
        <div className="flex items-center justify-between w-full gap-5">
          <img src={Logo} alt="Company Logo" />
          <h1>Prince Educational Supply</h1>
        </div>

        <form className="space-y-4" onSubmit={handleSubmit(handleLogin)}>
          <div className="flex flex-col space-y-2">
            <input
              placeholder="Username"
              id="username"
              {...register("userName")}
            />
            {errors.userName ? <span>{errors.userName.message}</span> : ""}
            <input
              type="password"
              id="password"
              placeholder="Password"
              {...register("password")}
            />
            {errors.password ? <span>{errors.password.message}</span> : ""}
          </div>

          <div className="flex justify-center">
            <button type="submit" className="w-full max-w-full">
              login
            </button>
          </div>
        </form>
      </div>
    </section>
  );
};

export default LoginPage;
