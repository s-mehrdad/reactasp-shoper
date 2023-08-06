// ===========================================================================
/// <summary>
/// aspnetcore-https.js
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

// This script sets up HTTPS for the application using the ASP.NET Core HTTPS certificate
import fs from "fs";
import { spawn } from "child_process";
import path from "path";

const baseFolder =
    process.env.APPDATA !== undefined && process.env.APPDATA !== ""
        ? `${process.env.APPDATA}/ASP.NET/https`
        : `${process.env.HOME}/.aspnet/https`;

const certificateArg = process.argv
    .map((arg) => arg.match(/--name=(?<value>.+)/i))
    .filter(Boolean)[0];
const certificateName = certificateArg
    ? certificateArg.groups.value
    : process.env.npm_package_name;

if (!certificateName) {
    console.error(
        "Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly."
    );
    process.exit(-1);
}

const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
    spawn(
        "dotnet",
        [
            "dev-certs",
            "https",
            "--export-path",
            certFilePath,
            "--format",
            "Pem",
            "--no-password",
        ],
        { stdio: "inherit" }
    ).on("exit", (code) => process.exit(code));
}
